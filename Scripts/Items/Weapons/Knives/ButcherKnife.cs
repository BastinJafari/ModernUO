namespace Server.Items
{
	[FlippableAttribute( 0x13F6, 0x13F7 )]
	public class ButcherKnife : BaseKnife
	{
		public override WeaponAbility PrimaryAbility => WeaponAbility.InfectiousStrike;
		public override WeaponAbility SecondaryAbility => WeaponAbility.Disarm;

		public override int AosStrengthReq => 5;
		public override int AosMinDamage => 9;
		public override int AosMaxDamage => 11;
		public override int AosSpeed => 49;
		public override float MlSpeed => 2.25f;

		public override int OldStrengthReq => 5;
		public override int OldMinDamage => 2;
		public override int OldMaxDamage => 14;
		public override int OldSpeed => 40;

		public override int InitMinHits => 31;
		public override int InitMaxHits => 40;

		[Constructible]
		public ButcherKnife() : base( 0x13F6 )
		{
			Weight = 1.0;
		}

		public ButcherKnife( Serial serial ) : base( serial )
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
