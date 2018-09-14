namespace Server.Items
{
	public class ElvenLoveseatEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed => new ElvenLoveseatEastDeed();

		[Constructible]
		public ElvenLoveseatEastAddon()
		{
			AddComponent( new AddonComponent( 0x3089 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 0x3088 ), 1, 0, 0 );
		}

		public ElvenLoveseatEastAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}

	public class ElvenLoveseatEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon => new ElvenLoveseatEastAddon();
		public override int LabelNumber => 1073372; // elven loveseat (east)

		[Constructible]
		public ElvenLoveseatEastDeed()
		{
		}

		public ElvenLoveseatEastDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
