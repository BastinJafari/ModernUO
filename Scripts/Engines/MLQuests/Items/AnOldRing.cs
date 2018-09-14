namespace Server.Items
{
	public class AnOldRing : GoldRing
	{
		public override int LabelNumber => 1075524; // an old ring

		[Constructible]
		public AnOldRing()
		{
			Hue = 0x222;
		}

		public AnOldRing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
