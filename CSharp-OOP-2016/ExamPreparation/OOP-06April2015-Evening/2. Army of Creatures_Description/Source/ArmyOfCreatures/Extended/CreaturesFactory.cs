﻿namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Creatures;

    public class CreaturesFactory : ICreaturesFactory
    {
        public Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new Goblin();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                case "Angel":
                    return new Angel();
                case "Archangel":
                    return new Archangel();
                case "ArchDevil":
                    return new ArchDevil();
                case "Behemoth":
                    return new Behemoth();
                case "Devil":
                    return new Devil();
                default:
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
            }
        }
    }
}
