﻿using System.Collections.Generic;
using System.Linq;
using World.GameActors.Tiles;

namespace World.ToyWorldCore
{
    public class Atlas
    {
        public Atlas()
        {
            TileLayers = new List<ITileLayer>();
            ObjectLayers = new List<IObjectLayer>();
            StaticTilesContainer = new Dictionary<int, StaticTile>();
        }

        public List<ITileLayer> TileLayers { get; private set; }

        public List<IObjectLayer> ObjectLayers { get; private set; }

        public IObjectLayer Avatars { get; set; }

        public IObjectLayer Characters { get; set; }

        public Dictionary<int, StaticTile> StaticTilesContainer { get; set; }

        public object GetLayer(LayerType layerType)
        {
            if (layerType == LayerType.Object 
                || layerType == LayerType.ForegroundObject)
            {
                return ObjectLayers.First(x => x.LayerType == layerType);
            }
            return TileLayers.First(x => x.LayerType == layerType);
        }
    }
}
