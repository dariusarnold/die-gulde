using GuldeLib.Entities;
using GuldeLib.Generators;
using GuldeLib.Maps;
using GuldeLib.Names;
using UnityEngine;

namespace GuldeLib.Builders
{
    public class LocationBuilder : Builder<Location>
    {
        public LocationBuilder WithNaming(GeneratableNaming naming)
        {
            Object.Naming = naming;
            return this;
        }

        public LocationBuilder WithEntryCell(GeneratableVector2Int entryCell)
        {
            Object.EntryCell = entryCell;
            return this;
        }

        public LocationBuilder WithEntryCell(int x, int y)
        {
            Object.EntryCell = new GeneratableVector2Int
            {
                Value = new Vector2Int(x, y)
            };
            return this;
        }

        public LocationBuilder WithMapPrefab(GameObject mapPrefab)
        {
            Object.MapPrefab = mapPrefab;
            return this;
        }

        public LocationBuilder WithEntityRegistry(GeneratableEntityRegistry entityRegistry)
        {
            Object.EntityRegistry = entityRegistry;
            return this;
        }
    }
}