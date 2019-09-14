using System.Collections.Generic;
using Server.Buffers;
using Server.Network;

namespace Server.Items
{
  public static class EquipmentPackets
  {
    public static void SendDisplayEquipmentInfo(NetState ns, Item item, int number, Mobile crafter, bool unidentified, ICollection<EquipInfoAttribute> attrs)
    {
      int packetLength = 17 +
                   (crafter != null ? 6 + crafter.Name?.Length ?? 0 : 0) +
                   (unidentified ? 4 : 0) + attrs.Count * 6;

      SpanWriter writer = new SpanWriter(stackalloc byte[packetLength]);

      writer.Write((byte)0xBF); // Extended Command Packet ID
      writer.Write((ushort)packetLength); // Dynamic Length

      writer.Write((short)0x10); // Command
      writer.Write(item.Serial);
      writer.Write(number);

      if (crafter != null)
      {
        string name = crafter.Name;

        writer.Write(-3);

        if (name == null)
          writer.Write((ushort)0);
        else
        {
          int length = name.Length;
          writer.Write((ushort)length);
          writer.WriteAsciiFixed(name, length);
        }
      }

      if (unidentified)
        writer.Write(-4);

      foreach (EquipInfoAttribute attr in attrs)
      {
        writer.Write(attr.Number);
        writer.Write((short)attr.Charges);
      }

      writer.Write(-1);

      ns.Send(writer.Span);
    }
  }
}