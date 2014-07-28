using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace Wineyes {
    public class Data {
        private enum Tags {
            LimbusDecentration = 0x190023,
            Diameter = 0x270023,
            PupilDiameter = 0x440046,
            PupilDecentration = 0x180023,
            IrisDiameter = 0x460046,

            Keratometry = 0x1100023,
            Flat = 0x800046,
            Steep = 0x740046,
            Power = 0x760046,
            Radius = 0x750046,
            Angle = 0x770046
        }
        public readonly Search.Image Img;
        public float IrisDiameter, PupilDiameter;
        public int Rings, Meridians = 256;
        public PointF LimbusDecentration, PupilDecentration;
        public List<float> Elevation, LocalRadii, SagittalRadii;

        public Sequence Flat, Steep;

        public Data(Search.Image img, Stream bcs) {
            this.Img = img;
            this.Elevation = new List<float>();
            using (BinaryReader br = new BinaryReader(bcs)) {
                do {
                    int tag = 0;
                    try { tag = br.ReadInt32(); }
                    catch (EndOfStreamException) { break; }
                    int len = br.ReadInt32();
                    string Name = Enum.GetName(typeof(Tags), tag);
                    switch ((Tags)tag) {
                        case Tags.IrisDiameter:
                            IrisDiameter = br.ReadSingle();
                            break;
                        case Tags.PupilDiameter:
                            PupilDiameter = br.ReadSingle();
                            break;
                        case Tags.PupilDecentration:
                            PupilDecentration = new PointF(br.ReadSingle(), br.ReadSingle());
                            break;
                        case Tags.LimbusDecentration:
                            LimbusDecentration = new PointF(br.ReadSingle(), br.ReadSingle());
                            break;
                        case Tags.Keratometry:
                            ReadSequence(new MemoryStream(br.ReadBytes(len)));
                            break;
                        default:
                            br.ReadBytes(len);
                            break;
                    }
                } while (true);

            }
        }

        private void ReadSequence(Stream s) {
            using (BinaryReader br = new BinaryReader(s)) {
                do {
                    try {
                        //            Item = 0xe000fffe,
                        uint item = br.ReadUInt32(); // item
                        int itemlength = br.ReadInt32(); // item length
                        ReadItem(new MemoryStream(br.ReadBytes(itemlength)));
                    }
                    catch (EndOfStreamException) { break; }
                } while (true);
            }
        }

        private void ReadItem(Stream s) {
            using (BinaryReader br = new BinaryReader(s)) {
                do {
                    try {
                        int tag = 0;
                        try { tag = br.ReadInt32(); }
                        catch (EndOfStreamException) { break; }
                        int len = br.ReadInt32();
                        switch ((Tags)tag) {
                            case Tags.Flat:
                                if (Flat == null) Flat = new Sequence(new MemoryStream(br.ReadBytes(len)));
                                break;
                            case Tags.Steep:
                                if (Steep == null) Steep = new Sequence(new MemoryStream(br.ReadBytes(len)));
                                break;
                            default:
                                br.ReadBytes(len);
                                break;
                        }
                    }
                    catch (EndOfStreamException) { break; }
                } while (true);
            }
        }

        public class Sequence {
            public float Power, Radius, Diameter;
            public short Angle;
            public Sequence(Stream sq) {
                using (BinaryReader br = new BinaryReader(sq)) {
                    try {
                        do {
                            int tag = 0;
                            try { tag = br.ReadInt32(); }
                            catch (EndOfStreamException) { break; }
                            int len = br.ReadInt32();
                            switch ((Tags)tag) {
                                case Tags.Diameter:
                                    Diameter = br.ReadSingle();
                                    break;
                                case Tags.Power:
                                    Power = br.ReadSingle();
                                    break;
                                case Tags.Radius:
                                    Radius = br.ReadSingle();
                                    break;
                                case Tags.Angle:
                                    Angle = br.ReadInt16();
                                    break;
                                default:
                                    br.ReadBytes(len);
                                    break;
                            }
                        } while (true);

                    }
                    catch (EndOfStreamException) { }
                }

            }
        }

    }
}
