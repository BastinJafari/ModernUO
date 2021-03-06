using System;
using Server.Mobiles;

namespace Server.Engines.Quests.Hag
{
  public class WitchApprenticeQuest : QuestSystem
  {
    private static Type[] m_TypeReferenceTable =
    {
      typeof(FindApprenticeObjective),
      typeof(FindGrizeldaAboutMurderObjective),
      typeof(KillImpsObjective),
      typeof(FindZeefzorpulObjective),
      typeof(ReturnRecipeObjective),
      typeof(FindIngredientObjective),
      typeof(ReturnIngredientsObjective),
      typeof(DontOfferConversation),
      typeof(AcceptConversation),
      typeof(HagDuringCorpseSearchConversation),
      typeof(ApprenticeCorpseConversation),
      typeof(MurderConversation),
      typeof(HagDuringImpSearchConversation),
      typeof(ImpDeathConversation),
      typeof(ZeefzorpulConversation),
      typeof(RecipeConversation),
      typeof(HagDuringIngredientsConversation),
      typeof(BlackheartFirstConversation),
      typeof(BlackheartNoPirateConversation),
      typeof(BlackheartPirateConversation),
      typeof(EndConversation),
      typeof(RecentlyFinishedConversation)
    };

    private static Point3D[] m_ZeefzorpulLocations =
    {
      new Point3D(1226, 1573, 0),
      new Point3D(1929, 1148, 0),
      new Point3D(1366, 2723, 0),
      new Point3D(1675, 2984, 0),
      new Point3D(2177, 3367, 10),
      new Point3D(1171, 3594, 0),
      new Point3D(1010, 2667, 5),
      new Point3D(1591, 2156, 5),
      new Point3D(2592, 464, 60),
      new Point3D(474, 1654, 0),
      new Point3D(897, 2411, 0),
      new Point3D(1471, 2505, 5),
      new Point3D(1257, 872, 16),
      new Point3D(2581, 1118, 0),
      new Point3D(2513, 1102, 0),
      new Point3D(1608, 3371, 0),
      new Point3D(4687, 1179, 0),
      new Point3D(3704, 2196, 20),
      new Point3D(3346, 572, 0),
      new Point3D(569, 1309, 0)
    };

    public WitchApprenticeQuest(PlayerMobile from) : base(from)
    {
    }

    // Serialization
    public WitchApprenticeQuest()
    {
    }

    public override Type[] TypeReferenceTable => m_TypeReferenceTable;

    public override object Name => 1055042;

    public override object OfferMessage => 1055001;

    public override TimeSpan RestartDelay => TimeSpan.FromMinutes(5.0);
    public override bool IsTutorial => false;

    public override int Picture => 0x15D3;

    public override void Accept()
    {
      base.Accept();

      AddConversation(new AcceptConversation());
    }

    public static Point3D RandomZeefzorpulLocation()
    {
      int index = Utility.Random(m_ZeefzorpulLocations.Length);

      return m_ZeefzorpulLocations[index];
    }
  }
}