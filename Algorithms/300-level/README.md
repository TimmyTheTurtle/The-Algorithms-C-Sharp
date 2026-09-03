# 300-Level Algorithms - Advanced CS

Welcome to **300-level algorithms**! These are advanced algorithms typically taught in Algorithms, Advanced Data Structures, and specialized electives (CS 301-350). Here you'll encounter sophisticated techniques that solve complex real-world problems.

## 📚 Learning Objectives

By completing this level, you will understand:
- Dynamic Programming (solving overlapping subproblems optimally)
- Advanced graph algorithms (Dijkstra, Bellman-Ford, Minimum Spanning Trees)
- Knapsack problem variants
- Graph coloring and scheduling problems
- Matrix operations and decompositions
- Modular arithmetic for cryptography
- Advanced numeric algorithms

## ⚠️ Prerequisites

**Before starting 300-level, you must be comfortable with:**
- All 200-level algorithms (especially sorting, searching, BFS/DFS)
- Understanding Big-O notation
- Recursion and memoization concepts
- Basic graph theory (nodes, edges, weighted graphs)
- Dynamic programming concepts (or prepared to learn!)

---

## 🎯 Recommended Learning Sequence

### Phase 1: Introduction to Dynamic Programming

Dynamic Programming solves problems with **overlapping subproblems** and **optimal substructure** by storing intermediate results.

#### 1.1 Sequence Problems (Warm-up)

- [ ] [**LongestIncreasingSubsequence** - LIS](./Sequences/LongestIncreasingSubsequence.cs) - Classic DP problem
- [ ] [**LongestCommonSubsequence** - LCS](./Sequences/LongestCommonSubsequence.cs) - Compare two sequences
- [ ] [**LongestCommonSubsequenceLength**](./Sequences/LongestCommonSubsequenceLength.cs) - Just the length

**Time to spend**: 1-1.5 hours  
**Key Takeaway**: DP builds solutions bottom-up from subproblems  
**What makes it work**: Storing results to avoid recalculation

---

#### 1.2 Numeric DP Problems

- [ ] [**CoinChange** - Minimum Coins](./CoinChange/CoinChange.cs) - Minimum coins needed for amount
- [ ] [**CoinChangeII** - Ways to Make Change](./Problems/CoinChangeII.cs) - Count all ways to make amount
- [ ] [**EditDistanceDamerau** - Damerau-Levenshtein Distance](./Problems/EditDistanceDamerau.cs) - Allow insertions, deletions, substitutions, transpositions

**Time to spend**: 1.5 hours  
**Key Takeaway**: DP solves "count the ways" and "minimum/maximum" problems  
**Real-world use**: Spell checking, RNA sequence alignment

---

### Phase 2: Knapsack Problems

The Knapsack problem is fundamental in optimization and resource allocation.

- [ ] [**ZeroOneKnapsack** - 0/1 Knapsack](./Knapsack/ZeroOneKnapsack.cs) - Each item used 0 or 1 time
- [ ] [**FractionalKnapsack** - Fractional Knapsack](./Knapsack/FractionalKnapsack.cs) - Can use part of items
- [ ] [**KnapsackZeroOne** - Variant Implementation](./Problems/KnapsackZeroOne.cs)
- [ ] Other Knapsack variants in Knapsack/

**Prerequisites**: Understand DP basics from Phase 1  
**Time to spend**: 1.5-2 hours  
**Key Takeaway**: Branch of optimization problems; 0/1 is NP-hard, Fractional is greedy  
**Real-world use**: Resource allocation, cargo loading, investment decisions

---

### Phase 3: Advanced Graph Algorithms

Now that you know BFS/DFS (200-level), learn algorithms for weighted graphs.

#### 3.1 Shortest Path Algorithms

- [ ] [**Dijkstra** - Dijkstra's Algorithm](./Dijkstra/Dijkstra.cs) - Shortest path, non-negative weights
- [ ] [**DijkstraAlgorithm** - Alternative Implementation](./Dijkstra/DijkstraAlgorithm.cs)
- [ ] [**BellmanFord** - Bellman-Ford Algorithm](./Problems/BellmanFord.cs) - Shortest path, allows negative weights
- [ ] [**FloydWarshall** - Floyd-Warshall Algorithm](./Problems/FloydWarshall.cs) - All-pairs shortest path

**Prerequisite**: Understand weighted graphs, priority queues  
**Time to spend**: 2-2.5 hours  
**Key Takeaway**: Different algorithms for different constraints  
**Complexity**:
- Dijkstra: O((V+E) log V) with heap
- Bellman-Ford: O(VE) but handles negative weights
- Floyd-Warshall: O(V³) but solves all-pairs

---

#### 3.2 Minimum Spanning Trees

Find the minimum-weight tree connecting all vertices.

- [ ] [**Kruskal** - Kruskal's Algorithm](./MinimumSpanningTree/Kruskal.cs) - Edge-based, uses Union-Find
- [ ] [**Prim** - Prim's Algorithm](./MinimumSpanningTree/Prim.cs) - Vertex-based, similar to Dijkstra
- [ ] [**MinimumSpanningTree** - Additional implementations](./Problems/MinimumSpanningTree.cs)

**Prerequisite**: Graph theory, Dijkstra  
**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Two different approaches to the same problem  
**Real-world use**: Network design, circuit design

---

#### 3.3 Graph Property Detection

- [ ] [**BipartiteCheck** - Check if Graph is Bipartite](./Problems/BipartiteCheck.cs) - Is it 2-colorable?
- [ ] [**ArticulationPoints** - Find Articulation Points](./Graph/ArticulationPoints.cs) - Critical nodes
- [ ] [**Bridges** - Find Bridge Edges](./Graph/Bridges.cs) - Critical edges
- [ ] [**StableMarriage** - Stable Marriage Problem](./StableMarriage/StableMarriage.cs) - Gale-Shapley algorithm
- [ ] [**TopologicalSortKhan** - Topological Sort (Khan's algorithm)](./Graph/TopologicalSortKhan.cs)

**Time to spend**: 1.5-2 hours  
**Key Takeaway**: Advanced graph analysis techniques

---

### Phase 4: Problem Solving with DP & Graphs

More complex problems combining multiple techniques.

- [ ] [**LongestValidParentheses** - Longest Valid Parentheses](./Problems/LongestValidParentheses.cs)
- [ ] [**NQueens** - N Queens Problem](./NQueens/NQueens.cs) - Backtracking with constraints
- [ ] [**KnightTour** - Knight's Tour](./KnightTour/KnightTour.cs) - Move knight to all squares
- [ ] [**TravelingSalesman** - TSP](./TravelingSalesman/TravelingSalesman.cs) - Visit all cities once, minimize distance
- [ ] [**JobScheduling** - Job Scheduling](./JobScheduling/JobScheduling.cs) - Optimal job ordering
- [ ] [**CombinationSum** - Combination Sum](./Problems/CombinationSum.cs) - Find combinations that sum to target
- [ ] [**FourSum** - Four Sum Problem](./Problems/FourSum.cs) - Find 4 numbers that sum to target
- [ ] [**LargestNumberByValue** - Arrange Numbers for Largest Value](./Problems/LargestNumberByValue.cs)

**Time to spend**: 2-3 hours  
**Key Takeaway**: Complex problems often combine multiple techniques  
**Challenge**: Some of these are NP-hard (no known polynomial solution)

---

### Phase 5: Matrix Operations

Advanced numeric and linear algebra algorithms.

- [ ] [**CholeskyDecomposition** - Cholesky Decomposition](./Decomposition/CholeskyDecomposition.cs) - LLT decomposition
- [ ] [**LuDecomposition** - LU Decomposition](./Decomposition/LuDecomposition.cs) - LU factorization
- [ ] [**QrDecomposition** - QR Decomposition](./Decomposition/QrDecomposition.cs) - Orthogonal decomposition
- [ ] [**SingularValueDecomposition** - SVD](./Decomposition/SingularValueDecomposition.cs) - Spectral analysis
- [ ] [**PseudoinverseMatrix** - Moore-Penrose Pseudoinverse](./Pseudoinverse/PseudoinverseMatrix.cs) - Generalized inverse

**Prerequisite**: Linear algebra basics  
**Time to spend**: 2-3 hours  
**Key Takeaway**: Matrix decomposition is foundation for ML, scientific computing  
**Real-world use**: Machine Learning, physics simulations, image compression

---

### Phase 6: Modular Arithmetic (Cryptography Foundation)

Number theory concepts essential for cryptography.

- [ ] [**ExtendedGCD** - Extended GCD](./Decomposition/ExtendedGCD.cs) - Bézout coefficients
- [ ] [**SteinsAlgorithm** - Stein's Algorithm](./Decomposition/SteinsAlgorithm.cs) - Binary GCD
- [ ] [**ModularExponential** - Fast Modular Exponentiation](./ModularArithmetic/ModularExponential.cs) - (a^b) mod m efficiently
- [ ] [**ModularMultiplicativeInverse** - Modular Inverse](./ModularArithmetic/ModularMultiplicativeInverse.cs) - Find x where (a*x) mod m = 1

**Prerequisite**: Numeric algorithms from 100/200-level  
**Time to spend**: 1.5 hours  
**Key Takeaway**: Foundation for RSA, elliptic curve cryptography  
**Real-world use**: Public-key cryptography, digital signatures

---

### Phase 7: Graph Coloring & Scheduling

- [ ] [**GraphColoring** - Graph Coloring Problem](./GraphColoring/GraphColoring.cs) - Color vertices with minimum colors
- [ ] [**JobScheduling variants** - Various scheduling problems](./JobScheduling/)

**Time to spend**: 1 hour  
**Key Takeaway**: NP-hard problems solved with approximation or heuristics

---

### Phase 8: Distance Metrics & Similarity

- [ ] [**LevenshteinDistance** - Edit Distance](./Distances/LevenshteinDistance.cs)
- [ ] Various similarity and distance metrics in Distances/

**Time to spend**: 45 minutes

---

## 🏆 Mastery Checklist

- [ ] Can solve a problem using Dynamic Programming
- [ ] Understand Dijkstra's algorithm and when to use it vs Bellman-Ford
- [ ] Can find Minimum Spanning Tree using Kruskal or Prim
- [ ] Know the difference between 0/1 and Fractional Knapsack
- [ ] Can explain why TSP is NP-hard
- [ ] Understand matrix decomposition concepts
- [ ] Know what modular exponentiation is and why it's useful

---

## 💡 Key Concepts at This Level

**Dynamic Programming**: Breaking problems into subproblems with optimal substructure  
**Greedy Algorithms**: Making locally optimal choices (works for some problems)  
**Backtracking**: Explore possibilities, abandon branches that don't work  
**Approximation Algorithms**: For NP-hard problems, find "good enough" solutions  
**Graph Theory**: Heavy use of graph algorithms and properties

---

## 📊 Complexity Reference

| Algorithm | Time | Space | Notes |
|-----------|------|-------|-------|
| Dijkstra | O((V+E) log V) | O(V) | Non-neg weights |
| Bellman-Ford | O(VE) | O(V) | Neg weights OK |
| Floyd-Warshall | O(V³) | O(V²) | All-pairs |
| Kruskal | O(E log E) | O(V) | MST |
| Prim | O((V+E) log V) | O(V) | MST |
| 0/1 Knapsack | O(nW) | O(nW) | Pseudo-poly |
| LCS | O(nm) | O(nm) | n,m = lengths |

---

## ⚠️ Difficulty Spike

**This level is harder** than 100/200. Take your time. Use paper and pencil. Draw graphs. Trace through algorithms step-by-step.

---

**Start with LongestIncreasingSubsequence to ease into DP, then tackle graphs. 300-level will make you a strong problem solver! 💪**
