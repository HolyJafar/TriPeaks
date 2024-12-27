using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriPeaks.GameLib
{
    //Declare a delegate for graph events.
    public delegate void EventDelegate(Vertex sender, EventArgs e);


    /// <summary>
    /// This class implement a directional graph data structures.
    /// </summary>
    class DirectionalGraph
    {
        #region Fields & Property

        private Vertex[] vertexs;
        private int count = 0;

        //Delcare the event that called when adjacentery changes.
        public event EventDelegate AdjacentChange;

        public Vertex[] Vertexs { get => vertexs; }
        public int Count { get => count; }

        #endregion

        //constructor
        public DirectionalGraph(int capacity)
        {
            vertexs = new Vertex[capacity];
        }

        #region methodes

        public void AddVertex(object v)
        {
            if (count == vertexs.Length) throw new Exception("Graph is Fulll.");

            if (Find(v) == null)
                if (v is Vertex)
                    vertexs[count++] = v as Vertex;
                else
                    vertexs[count++] = new Vertex(v);
        }

        public void AddVertex(Vertex vertex)
        {
            if (count == vertexs.Length) throw new Exception("Graph is Fulll.");

            if (!vertexs.Contains(vertex))
            {
                vertexs[count++] = vertex;
                foreach (Vertex i in vertex.AdjacentParents)
                {
                    if (!vertexs.Contains(i))
                    {
                        AddVertex(i);
                    }
                    AddEdge(i, vertex);
                }

            }
        }

        public void AddEdge(object a, object b)
        {

            Vertex v1 = Find(a);
            Vertex v2 = Find(b);

            if (v1 != null && v2 != null && !v1.AdjacentChilds.Contains(v2))
            {
                v1.AddChild(v2);
                v2.AddParent(v1);
            }

            //Raise the AdjacentChange event
            AdjacentChange?.Invoke(v1, EventArgs.Empty);
            AdjacentChange?.Invoke(v2, EventArgs.Empty);
        }

        public void RemoveVertex(object v)
        {
            Vertex temp = Find(v);

            if (temp != null)
            {

                foreach (Vertex i in temp.AdjacentParents.Union(temp.AdjacentChilds))
                {
                    i.RemoveAdjacent(temp);

                    //Raise the AdjacentChange event
                    AdjacentChange?.Invoke(i, EventArgs.Empty);
                }

                vertexs[GetIndex(temp)] = vertexs[--count];
                vertexs[count] = null;
            }
        }

        public Vertex Find(object v)
        {
            if (v is Vertex)
                return v as Vertex;

            else
                for (int i = 0; i < count; i++)
                {
                    if (vertexs[i].Value == null)
                        continue;

                    if (vertexs[i].Value.Equals(v))
                        return vertexs[i];
                }

            return null;
        }

        public void Clear()
        {
            vertexs = new Vertex[vertexs.Length];
        }

        public List<Vertex> BFS(object from)
        {
            List<Vertex> output = new List<Vertex>();

            Queue temp = new Queue();

            temp.Enqueue(Find(from));

            while (temp.Count > 0)
            {
                while (output.Contains(temp.Peek()))
                    temp.Dequeue();

                output.Add(temp.Dequeue() as Vertex);

                foreach (Vertex i in output.Last().AdjacentChilds)
                    if (!temp.Contains(i))
                        temp.Enqueue(i);

            }

            return output;
        }

        private int GetIndex(Vertex v)
        {
            for (int i = 0; i < count; i++)
                if (vertexs[i] == v)
                    return i;

            return -1;
        }

        #endregion
    }

    /// <summary>
    /// this class implements graph nodes.
    /// </summary>
    public class Vertex
    {
        #region Fields

        //the graph is directional so we seperate parents and chileds
        //with two lists.
        private List<Vertex> adjacentChilds;
        private List<Vertex> adjacentParents;
        private object value;

        #endregion


        #region Property

        public int AdjCount => adjacentChilds.Count + adjacentParents.Count; 
        public List<Vertex> AdjacentChilds { get => adjacentChilds; }
        public List<Vertex> AdjacentParents { get => adjacentParents; }
        public object Value { get => value; set => this.value = value; }

        #endregion

        //constructor
        public Vertex(object value)
        {
            this.value = value;
            adjacentChilds = new List<Vertex>();
            adjacentParents = new List<Vertex>();
        }


        #region methodes

        public void AddChild(Vertex Neighbour)
        {
            if (!adjacentChilds.Contains(Neighbour))
                adjacentChilds.Add(Neighbour);
        }

        public void AddParent(Vertex Neighbour)
        {
            if (!adjacentParents.Contains(Neighbour))
                adjacentParents.Add(Neighbour);
        }

        public void RemoveAdjacent(Vertex Neighbour)
        {
            if (adjacentChilds.Contains(Neighbour))
                adjacentChilds.Remove(Neighbour);

            if (adjacentParents.Contains(Neighbour))
                adjacentParents.Remove(Neighbour);
        }

        #endregion
    }

}

