﻿using Core.Entities;

namespace CardRPG.Entities.Gameplay
{
    public class Card
    {
        public CardId Id { get; }
        public string Name { get; }
        public StatisticPointGroup Statistics { get; }

        public Card(
            CardId id,
            string name,
            StatisticPointGroup statistics)
        {
            Id = id;
            Name = name;
            Statistics = statistics;
        }

        public Card DeepCopy() =>
            new(new CardId(Id.Value),
                Name, Statistics.DeepCopy());
    }

    public class CardId : EntityId { public CardId(string value) : base(value) { } }
}
