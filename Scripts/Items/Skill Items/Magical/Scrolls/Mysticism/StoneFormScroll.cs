namespace Server.Items
{
	public class StoneFormScroll : SpellScroll
	{
		[Constructible]
		public StoneFormScroll()
			: this( 1 )
		{
		}

		[Constructible]
		public StoneFormScroll( int amount )
			: base( 684, 0x2DA5, amount )
		{
		}

		public StoneFormScroll( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			/*int version = */
			reader.ReadInt();
		}
	}
}
