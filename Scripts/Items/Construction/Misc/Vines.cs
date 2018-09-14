namespace Server.Items
{
	public class Vines : Item
	{
		[Constructible]
		public Vines() : this( Utility.Random( 8 ) )
		{
		}

		[Constructible]
		public Vines( int v ) : base( 0xCEB )
		{
			if ( v < 0 || v > 7 )
				v = 0;

			ItemID += v;
			Weight = 1.0;
		}

		public Vines(Serial serial) : base(serial)
		{
		}

		public override bool ForceShowProperties => ObjectPropertyList.Enabled;

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}
