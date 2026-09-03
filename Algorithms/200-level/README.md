# 200-Level Algorithms - Intermediate CS

Welcome to **200-level algorithms**! These are intermediate algorithms typically taught in Data Structures and basic Algorithms courses (CS 201/202). You'll learn more efficient techniques and encounter your first complex data structures.

## 📚 Learning Objectives

By completing this level, you will understand:
- Efficient searching algorithms (Binary Search and variants)
- Fast sorting algorithms (Merge Sort, Quick Sort)
- Graph fundamentals (BFS, DFS)
- String pattern matching algorithms (KMP, Rabin-Karp)
- Basic data compression
- Cryptographic encoding techniques
- More advanced numeric algorithms

## 🎯 Recommended Learning Sequence

### Phase 1: Efficient Searching (Build on 100-level)

Before starting, you should know Linear Search from 100-level.

- [ ] [**BinarySearcher** - Binary Search](./Search/BinarySearcher.cs) - Divide and conquer search, O(log n)
- [ ] [**SentinelBinarySearcher** - Binary Search with Sentinel](./Search/SentinelBinarySearcher.cs)
- [ ] [**JumpSearcher** - Jump Search](./Search/JumpSearcher.cs) - Skip elements for faster search
- [ ] [**ExponentialSearcher** - Exponential Search](./Search/ExponentialSearcher.cs) - For unbounded arrays
- [ ] [**InterpolationSearcher** - Interpolation Search](./Search/InterpolationSearcher.cs) - Estimate position
- [ ] [**TernarySearcher** - Ternary Search](./Search/TernarySearcher.cs) - Divide into three

**Prerequisite**: Linear Search (100-level)  
**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Binary Search is O(log n) - massively faster than Linear for large datasets  
**Important**: Most of these require SORTED data

---

### Phase 2: Advanced Sorting (Much Faster!)

You know Bubble/Selection/Insertion sorts. Now learn the fast ones.

#### 2.1 Divide-and-Conquer Sorting

- [ ] [**MergeSort** - Merge Sort](./Comparison/MergeSort.cs) - O(n log n), guaranteed, uses extra space
- [ ] [**QuickSort** - Quick Sort](./Comparison/QuickSort.cs) - O(n log n) average, O(n²) worst, in-place

#### 2.2 Other Efficient Sorts

- [ ] [**HeapSorter** - Heap Sort](./Comparison/HeapSorter.cs) - O(n log n), in-place
- [ ] [**CombSorter** - Comb Sort](./Comparison/CombSorter.cs) - Improved Bubble Sort
- [ ] [**ShellSort** - Shell Sort](./Comparison/ShellSort.cs) - In-place, faster than Insertion
- [ ] [**BitonicSorter** - Bitonic Sort](./Comparison/BitonicSorter.cs) - Parallel-friendly sort
- [ ] [**CocktailSorter** - Cocktail Sort](./Comparison/CocktailSorter.cs) - Bidirectional Bubble Sort

**Prerequisite**: Basic sorting from 100-level  
**Time to spend**: 2-2.5 hours  
**Key Takeaway**: O(n log n) is much faster than O(n²) for large data  
**Critical Understanding**: Trade-offs between time, space, and implementation complexity

---

### Phase 3: Graph Fundamentals

Introduction to graph algorithms - the foundation for many real-world problems.

- [ ] [**BreadthFirstSearch** - BFS](./Graph/BreadthFirstSearch.cs) - Level-by-level exploration, queue-based
- [ ] [**DepthFirstSearch** - DFS](./Graph/DepthFirstSearch.cs) - Deep exploration, stack-based
- [ ] [**TopologicalSort** - Topological Sorting](./Graph/TopologicalSort.cs) - Ordering for DAGs

**Prerequisite**: Understand queues and stacks (from 100-level Stack)  
**Time to spend**: 1.5-2 hours  
**Key Takeaway**: Two fundamental ways to traverse graphs; basis for many algorithms  
**Real-world use**: BFS/DFS are used in social networks, maze solving, dependency resolution

---

### Phase 4: String Pattern Matching (Beyond Naive)

100-level taught you naive matching. Now learn efficient approaches.

- [ ] [**KMPSearch** - Knuth-Morris-Pratt Search](./PatternMatching/KMPSearch.cs) - O(n+m), uses failure function
- [ ] [**RabinKarp** - Rabin-Karp Algorithm](./PatternMatching/RabinKarp.cs) - Hashing-based, handles multiple patterns
- [ ] [**ZAlgorithm** - Z Algorithm](./PatternMatching/ZAlgorithm.cs) - Linear pattern matching
- [ ] [**CalculateEditDistance** - Edit Distance / Levenshtein](./PatternMatching/CalculateEditDistance.cs) - Similarity measure

**Prerequisite**: String basics from 100-level  
**Time to spend**: 2-2.5 hours  
**Key Takeaway**: Naive search is O(n×m), these are O(n+m)  
**Real-world use**: Text editors, DNA sequencing, plagiarism detection

---

### Phase 5: Numeric Algorithms - Intermediate

Build on 100-level numeric algorithms.

- [ ] [**FastFourierTransform** - FFT](./Numeric/FastFourierTransform.cs) - Polynomial multiplication, signal processing
- [ ] [**LeastCommonMultiple** - LCM](./Numeric/LeastCommonMultiple.cs) - Extends GCD from 100-level
- [ ] [**PrimeFactors** - Prime Factorization](./Integer/PrimeFactors.cs) - Factor a number into primes
- [ ] [**SumOfDivisors** - Sum of Divisors](./Numeric/SumOfDivisors.cs) - Number theory
- [ ] [**PalindromNumber** - Check if Number is Palindrome](./Numeric/PalindromNumber.cs) - Numeric palindrome

**Prerequisite**: Numeric basics and prime checking from 100-level  
**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Advanced number theory concepts

---

### Phase 6: Encoding & Cryptography Basics

Introduction to cryptographic concepts and encoding schemes.

- [ ] [**CaesarEncoder** - Caesar Cipher](./Encoders/CaesarEncoder.cs) - Simple shift cipher
- [ ] [**VigenereEncoder** - Vigenere Cipher](./Encoders/VigenereEncoder.cs) - Multi-shift cipher
- [ ] [**HillEncoder** - Hill Cipher](./Encoders/HillEncoder.cs) - Matrix-based encryption
- [ ] [**AutokeyEncoder** - Autokey Cipher](./Encoders/AutokeyEncoder.cs) - Key-dependent cipher
- [ ] [**FeistelCipher** - Feistel Cipher](./Encoders/FeistelCipher.cs) - Foundation of DES
- [ ] [**BlowfishEncoder** - Blowfish Cipher](./Encoders/BlowfishEncoder.cs) - Fast block cipher
- [ ] [**SoundexEncoder** - Soundex Encoding](./Encoders/SoundexEncoder.cs) - Phonetic encoding
- [ ] [**NysiisEncoder** - NYSIIS Encoding](./Encoders/NysiisEncoder.cs) - Phonetic encoding variant

**Prerequisite**: String manipulation from 100-level  
**Time to spend**: 2-3 hours  
**Key Takeaway**: How encryption works at a basic level (More advanced at 300/400-level)  
**Important**: These are educational - don't use for real security!

---

### Phase 7: Data Compression

Learn how to make data smaller.

- [ ] [**BurrowsWheelerTransform** - Burrows-Wheeler Transform](./DataCompression/BurrowsWheelerTransform.cs) - Preprocessing for compression
- [ ] [**HuffmanCompressor** - Huffman Coding](./DataCompression/HuffmanCompressor.cs) - Variable-length encoding, optimal for symbols
- [ ] [**ShannonFanoCompressor** - Shannon-Fano Coding](./DataCompression/ShannonFanoCompressor.cs) - Prefix-free code

**Prerequisite**: Sorting algorithms (done in Phase 2)  
**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Compression reduces data size by exploiting redundancy  
**Real-world use**: ZIP files, image compression, network transmission

---

### Phase 8: More Sequences & Advanced Numeric

- [ ] [**CatlanNumber** - Catalan Numbers](./Sequences/CatlanNumber.cs) - Combinatorial numbers
- [ ] [**EvenFibonacci** - Even Fibonacci Numbers](./Sequences/EvenFibonacci.cs) - Filtered sequences
- [ ] [**PartitionFunction** - Partition Function](./Sequences/PartitionFunction.cs) - Number partitioning
- [ ] [**Modular Exponentiation** - Fast modular power](./Numeric/Modular.cs) - Important for cryptography

**Time to spend**: 1 hour  
**Key Takeaway**: Advanced sequence generation

---

### Phase 9: Shuffling & Randomization

- [ ] [**KnuthShuffle** - Knuth Shuffle (Fisher-Yates)](./Shufflers/KnuthShuffle.cs) - Perfectly random
- [ ] Other shuffle variants

**Time to spend**: 20-30 minutes

---

## 🏆 Mastery Checklist

- [ ] Can implement Binary Search
- [ ] Understand why Merge Sort is O(n log n)
- [ ] Can do BFS/DFS by hand on a small graph
- [ ] Know the difference between KMP and Naive string search
- [ ] Understand Caesar Cipher and why it's weak
- [ ] Can explain how Huffman Coding works

---

## 💡 Important Concepts at This Level

**Time Complexity**: You'll see O(n log n), O(n²), O(log n)  
**Divide and Conquer**: Core concept in Merge Sort, Binary Search  
**Graph Traversal**: Two fundamental techniques (BFS/DFS)  
**Hash-based Algorithms**: Rabin-Karp uses hashing  
**Greedy Algorithms**: Huffman Coding is greedy

---

## 🚀 Prerequisites & Next Steps

**Before starting 200-level, ensure you can**:
- Implement Bubble Sort
- Understand Big-O notation
- Know what recursion is
- Understand basic graph concepts (nodes, edges)

**After 200-level, you'll be ready for**:
- **300-level**: Dynamic Programming, Advanced Graph Algorithms (Dijkstra, A*), Knapsack
- 400-level techniques
- Real-world problem solving

---

## 📊 Complexity Reference

| Algorithm | Time | Space | Notes |
|-----------|------|-------|-------|
| Binary Search | O(log n) | O(1) | Requires sorted data |
| Merge Sort | O(n log n) | O(n) | Guaranteed, stable |
| Quick Sort | O(n log n) avg | O(log n) | Fast average case |
| BFS | O(V+E) | O(V) | Queue-based |
| DFS | O(V+E) | O(V) | Stack-based |
| KMP Search | O(n+m) | O(m) | Much faster than naive |
| Huffman | O(n log n) | O(n) | Optimal prefix code |

---

**Start with BinarySearcher and work your way through. These algorithms will make you much faster at problem-solving! 🚀**
