using Server.Mobiles;

namespace Server.Engines.Quests.Samurai
{
  public class HaochisKatana : QuestItem
  {
    [Constructible]
    public HaochisKatana() : base(0x13FF) => Weight = 1.0;

    public HaochisKatana(Serial serial) : base(serial)
    {
    }

    public override int LabelNumber => 1063165; // Daimyo Haochi's Katana

    public override bool CanDrop(PlayerMobile player) => !(player.Quest is HaochisTrialsQuest);

    public override void Serialize(GenericWriter writer)
    {
      base.Serialize(writer);

      writer.WriteEncodedInt(0); // version
    }

    public override void Deserialize(GenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadEncodedInt();
    }
  }
}