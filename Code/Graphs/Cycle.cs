﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code;

namespace Code.Graphs
{
    // This is for undirected graph
    public class Cycle
    {
        private bool[] _marked;
        private bool _hasCycle;

        public Cycle(Graph g)
        {
            _marked = new bool[g.V];
            for (var s = 0; s < g.V; s++)
            {
                if (!_marked[s])
                    Dfs(g, s, s);
            }
        }

        public bool HasCycle
        {
            get { return _hasCycle; }
        }


        private void Dfs (Graph g, int v, int u)
        {
            _marked[v] = true;
            foreach (var w in g.GetAdjList(v))
            {
                if (!_marked[w])
                    Dfs(g, w, v);
                else
                    if (w != u) _hasCycle = true;
            }
        }
    }
}
