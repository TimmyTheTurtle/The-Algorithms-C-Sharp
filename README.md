# The Algorithms - C# 

A comprehensive collection of algorithms implemented in C#, organized by Computer Science curriculum complexity levels for educational purposes.

## 📚 Organization

This repository reorganizes algorithms by the **complexity level they are typically taught at** in Computer Science education, rather than by category. This structure helps you find algorithms by their difficulty and prerequisites.

### Curriculum Levels

```
Algorithms/
├── 100-level/          ← Introductory algorithms (CS 101-102)
├── 200-level/          ← Intermediate algorithms (CS 201-202)
├── 300-level/          ← Advanced algorithms (CS 301-302)
├── 400-level/          ← Senior-level algorithms (CS 401-402)
└── specialized/        ← Domain-specific implementations
    ├── Crypto/         ← Cryptographic algorithms
    ├── MachineLearning/← ML algorithms and techniques
    ├── Financial/      ← Financial computations
    └── RecommenderSystem/ ← Recommendation algorithms
```

### Level Descriptions

#### **100-Level** (43 algorithms)
Introductory algorithms suitable for CS 1/CS 2 courses:
- **Search**: Linear search, sentinel search
- **Sorters**: Bubble sort, selection sort, insertion sort
- **Strings**: Palindrome checking, string reversal, anagrams
- **Stack**: Basic stack operations
- **Numeric**: Factorial, GCD, LCM, prime checking
- **Sequences**: Fibonacci, arithmetic/geometric sequences
- **Shufflers**: Fisher-Yates shuffle

*Example*: `100-level/Sorters/BubbleSorter.cs`

#### **200-Level** (96 algorithms)
Intermediate algorithms typically in CS 2/CS 3 and Data Structures courses:
- **Search**: Binary search, jump search, exponential search
- **Sorters**: Merge sort, quick sort, heap sort
- **Graph**: BFS, DFS, topological sort
- **Strings**: Pattern matching, string compression
- **Encoders**: Caesar, Vigenere, Hill ciphers
- **Data Compression**: Huffman, Shannon-Fano, Burrows-Wheeler
- **Numeric**: Modular exponentiation, prime factorization
- **Sequences**: Catalan numbers, partition functions

*Example*: `200-level/Sorters/MergeSort.cs`

#### **300-Level** (71 algorithms)
Advanced algorithms typically in Algorithms and Advanced Data Structures courses:
- **Graph**: Dijkstra's, Bellman-Ford, minimum spanning trees (Prim's, Kruskal's)
- **Knapsack**: 0/1 Knapsack, fractional knapsack, variants
- **Problems**: Longest common subsequence, edit distance, coin change
- **Numeric**: Matrix operations, decomposition methods
- **Modular Arithmetic**: Extended GCD, modular inverse
- **Sequences**: Dynamic programming sequences

*Example*: `300-level/Graph/Dijkstra/DijkstraAlgorithm.cs`

#### **400-Level** (22 algorithms)
Senior and specialized algorithms for Algorithms II and advanced courses:
- **Search**: A* pathfinding
- **Sorters**: TimSort, advanced sorting optimizations
- **Graph**: Advanced graph algorithms and optimizations
- **Numeric**: Specialized numeric computations

*Example*: `400-level/Search/AStar/AStarAlgorithm.cs`

#### **Specialized** (21 algorithms)
Domain-specific implementations:
- **Crypto**: Cryptographic digests and paddings (MD2, Ascon, PKCS7, ISO7816)
- **MachineLearning**: Neural networks, clustering, decision trees
- **Financial**: Financial calculations and models
- **RecommenderSystem**: Recommendation algorithms

*Example*: `specialized/Crypto/Digests/AsconDigest.cs`

## 📂 Directory Structure Example

```
Algorithms/
├── 100-level/
│   ├── Search/
│   │   ├── LinearSearcher.cs
│   │   └── SentinelSearcher.cs
│   ├── Sorters/
│   │   ├── BubbleSorter.cs
│   │   ├── SelectionSorter.cs
│   │   └── InsertionSorter.cs
│   └── Strings/
│       ├── PalindromeChecker.cs
│       └── AnagramChecker.cs
│
├── 200-level/
│   ├── Search/
│   │   ├── BinarySearcher.cs
│   │   └── JumpSearcher.cs
│   ├── Sorters/
│   │   ├── MergeSort.cs
│   │   └── QuickSort.cs
│   └── Graph/
│       ├── BreadthFirstSearch.cs
│       └── DepthFirstSearch.cs
│
├── 300-level/
│   ├── Graph/
│   │   ├── Dijkstra/
│   │   │   └── DijkstraAlgorithm.cs
│   │   └── MinimumSpanningTree/
│   │       ├── Kruskal.cs
│   │       └── Prim.cs
│   └── Knapsack/
│       └── ZeroOneKnapsack.cs
│
└── specialized/
    ├── Crypto/
    │   ├── Digests/
    │   │   └── AsconDigest.cs
    │   └── Paddings/
    │       └── Pkcs7Padding.cs
    └── MachineLearning/
        └── NeuralNetwork/
```

## 🛠️ Building the Project

Requirements:
- .NET 8.0 or higher
- Visual Studio, Visual Studio Code, or any .NET IDE

```bash
# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run tests
dotnet test
```

## 📁 Additional Folders

- **Algorithms.Tests** - Unit tests for all algorithms
- **DataStructures** - Data structure implementations
- **DataStructures.Tests** - Data structure tests
- **Utilities** - Utility functions and helpers

## 🎓 Learning Path

Start with **100-level** algorithms to build fundamentals, then progress through **200-level**, **300-level**, and **400-level** as you deepen your understanding. **Specialized** algorithms can be explored at any point based on your interests.

## 📝 Contributing

To add new algorithms:
1. Determine the appropriate curriculum level
2. Place the implementation in the correct level and category folder
3. Add corresponding tests to `Algorithms.Tests`
4. Ensure the code builds successfully

## 📄 License

This repository is licensed under the MIT License. See LICENSE file for details.

## 🔗 Related

- Original repository: [TheAlgorithms/C-Sharp](https://github.com/TheAlgorithms/C-Sharp)
- This fork: [TimmyTheTurtle/The-Algorithms-C-Sharp](https://github.com/TimmyTheTurtle/The-Algorithms-C-Sharp)

---

**Last Reorganized**: September 3, 2026  
**Total Algorithms**: 254  
**Verification Status**: ✅ All algorithms accounted for, project builds successfully
