using System;

namespace Server.Items
{
	public class GreaterStrengthPotion : BaseStrengthPotion
	{
		public override int StrOffset => 20;
		public override TimeSpan Duration => TimeSpan.FromMinutes( 2.0 );

		[Constructible]
		public GreaterStrengthPotion() : base( PotionEffect.StrengthGreater )
		{
		}

		public GreaterStrengthPotion( Serial serial ) : base( serial )
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
