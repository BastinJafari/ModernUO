namespace Server.Items
{
	public class MassCurseScroll : SpellScroll
	{
		[Constructible]
		public MassCurseScroll() : this( 1 )
		{
		}

		[Constructible]
		public MassCurseScroll( int amount ) : base( 45, 0x1F5A, amount )
		{
		}

		public MassCurseScroll( Serial serial ) : base( serial )
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

			int version = reader.ReadInt();
		}

		
	}
}