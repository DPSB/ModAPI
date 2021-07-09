namespace Respec
{
    class UICharacterEx : UICharacter
    {
        public override void Refresh()
        {
            base.Refresh();
            btnResetPoints.SetActive(true);
        }

        public override void ResetPoints()
        {
            curCustomization._ID.attributePoints += curCustomization._ID.vitality +
                                                    curCustomization._ID.power +
                                                    curCustomization._ID.agility +
                                                    curCustomization._ID.strength;
            curCustomization._ID.strength = 0;
            curCustomization._ID.power = 0;
            curCustomization._ID.agility = 0;
            curCustomization._ID.vitality = 0;

            curCustomization._ID.skillPoints += curCustomization.daggerproficiency +
                                                curCustomization.swordproficiency +
                                                curCustomization.axeproficiency +
                                                curCustomization.maceproficiency +
                                                curCustomization.bowproficiency +
                                                curCustomization.blocking +
                                                curCustomization.phatomslashes +
                                                curCustomization.focus +
                                                curCustomization.ironbody +
                                                curCustomization.hardenedskin +
                                                curCustomization.ignorpain +
                                                curCustomization.atheletic +
                                                curCustomization.dodging +
                                                curCustomization.recreation +
                                                curCustomization.healaura +
                                                curCustomization.fireball +
                                                curCustomization.frostbite +
                                                curCustomization.painfulscream +
                                                curCustomization.alchemist +
                                                curCustomization.elementalresistence +
                                                curCustomization.goldenhand +
                                                curCustomization.scavenger +
                                                curCustomization.crystalhunter +
                                                curCustomization.trading +
                                                curCustomization.commanding +
                                                curCustomization.summoner +
                                                curCustomization.fastlearner;
            curCustomization.daggerproficiency = 0;
            curCustomization.swordproficiency = 0;
            curCustomization.axeproficiency = 0;
            curCustomization.maceproficiency = 0;
            curCustomization.bowproficiency = 0;
            curCustomization.blocking = 0;
            curCustomization.phatomslashes = 0;
            curCustomization.focus = 0;
            curCustomization.ironbody = 0;
            curCustomization.hardenedskin = 0;
            curCustomization.ignorpain = 0;
            curCustomization.atheletic = 0;
            curCustomization.dodging = 0;
            curCustomization.recreation = 0;
            curCustomization.healaura = 0;
            curCustomization.fireball = 0;
            curCustomization.frostbite = 0;
            curCustomization.painfulscream = 0;
            curCustomization.alchemist = 0;
            curCustomization.elementalresistence = 0;
            curCustomization.goldenhand = 0;
            curCustomization.scavenger = 0;
            curCustomization.crystalhunter = 0;
            curCustomization.trading = 0;
            curCustomization.commanding = 0;
            curCustomization.summoner = 0;
            curCustomization.fastlearner = 0;

            base.ResetPoints();
        }
    }
}