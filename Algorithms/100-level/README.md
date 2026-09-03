# 100-Level Algorithms - Introductory CS

Welcome to the **100-level algorithms**! These are fundamental algorithms typically taught in introductory Computer Science courses (CS 101/102). You'll learn the basic building blocks of computer science: searching, sorting, string manipulation, and basic numeric algorithms.

## 📚 Learning Objectives

By completing this level, you will understand:
- How basic searching algorithms work
- Fundamental sorting techniques
- String manipulation and pattern recognition
- Simple numeric computations
- Data structure operations (stacks)
- Sequence generation

## 🎯 Recommended Learning Sequence

### Phase 1: Understand the Basics (Start Here!)

#### 1.1 Basic Numeric Operations
Start by understanding simple numeric computations. These form the foundation for more complex algorithms.

- [ ] [**Abs** - Absolute Value](./Numeric/Abs.cs) - Start with this simple operation
- [ ] [**Ceil** - Ceiling Function](./Numeric/Ceil.cs) - Rounding up
- [ ] [**Floor** - Floor Function](./Numeric/Floor.cs) - Rounding down
- [ ] [**Factorial** - Factorial Calculation](./Numeric/Factorial.cs) - Understanding recursion basics
- [ ] [**DoubleFactorial**](./Numeric/DoubleFactorial.cs) - Factorial variant
- [ ] [**PrimeChecker** - Check if Number is Prime](./Numeric/PrimeChecker.cs) - Important for cryptography later
- [ ] [**PerfectSquareChecker** - Check for Perfect Squares](./Numeric/PerfectSquareChecker.cs)
- [ ] [**PerfectCubeChecker** - Check for Perfect Cubes](./Numeric/PerfectCubeChecker.cs)
- [ ] [**PerfectNumberChecker** - Check for Perfect Numbers](./Numeric/PerfectNumberChecker.cs)
- [ ] [**AdditionWithoutArithmetic** - Addition using Bitwise Ops](./Numeric/AdditionWithoutArithmetic.cs) - See how hardware works
- [ ] [**SumOfDigits** - Sum the Digits of a Number](./Numeric/SumOfDigits.cs)

**Time to spend**: 1-2 hours  
**Key Takeaway**: Understand iterative and recursive approaches to numeric problems

---

#### 1.2 Searching Algorithms
Now learn how to find things. These are the simplest search approaches.

- [ ] [**LinearSearcher** - Linear Search](./Search/LinearSearcher.cs) - Most basic search, O(n)
- [ ] [**SentinelSearcher** - Sentinel Search](./Search/SentinelSearcher.cs) - Optimized linear search

**Time to spend**: 30-45 minutes  
**Key Takeaway**: Not all searches need to be fancy; sometimes simple is best

---

#### 1.3 Basic String Operations
Work with text and understand string manipulation patterns.

- [ ] [**Palindrome** - Check if String is Palindrome](./Strings/Palindrome.cs) - Is it the same forwards and backwards?
- [ ] [**Reverse** - Reverse a String](./Strings/Reverse.cs) - String manipulation
- [ ] [**AnagramChecker** - Check if Two Strings are Anagrams](./Strings/AnagramChecker.cs) - Character comparison
- [ ] [**ToggleCase** - Toggle Character Case](./Strings/ToggleCase.cs) - Character transformation
- [ ] [**RemoveVowels** - Remove Vowels from String](./Strings/RemoveVowels.cs) - String filtering
- [ ] [**IsRotation** - Check if One String is Rotation of Another](./Strings/IsRotation.cs) - Pattern matching basics
- [ ] [**ValidateIP** - Validate IP Address Format](./Strings/ValidateIP.cs) - Format validation
- [ ] [**Tokenizer** - Tokenize a String](./Strings/Tokenizer.cs) - Breaking strings into parts

**Time to spend**: 1.5-2 hours  
**Key Takeaway**: Master string manipulation - it's used everywhere

---

### Phase 2: Understand Sorting (The Classic)

Sorting is one of the most important algorithms. Learn simple approaches first.

#### 2.1 Basic Comparison-Based Sorting

- [ ] [**BubbleSorter** - Bubble Sort](./Comparison/BubbleSorter.cs) - The simplest sort, O(n²)
- [ ] [**SelectionSorter** - Selection Sort](./Comparison/SelectionSorter.cs) - Select minimum, move it
- [ ] [**InsertionSorter** - Insertion Sort](./Comparison/InsertionSorter.cs) - Build sorted array incrementally
- [ ] [**ExchangeSorter** - Exchange Sort (Bubble variant)](./Comparison/ExchangeSorter.cs)
- [ ] [**GnomeSorter** - Gnome Sort (Insertion variant)](./Comparison/GnomeSorter.cs)

**Time to spend**: 2-3 hours  
**Key Takeaway**: Understand time complexity tradeoffs (Simple = Slow, but easy to understand)  
**Important**: All of these are O(n²), which is slow for large datasets

---

### Phase 3: Sequences and Patterns

Learn to generate and work with mathematical sequences.

- [ ] [**FibonacciSequence** - Fibonacci Numbers](./Sequences/FibonacciSequence.cs) - Famous recursive sequence
- [ ] [**ArithmeticSequence** - Arithmetic Progression](./Sequences/ArithmeticSequence.cs) - Constant difference
- [ ] [**GeometricSequence** - Geometric Progression](./Sequences/GeometricSequence.cs) - Constant ratio
- [ ] [**EvenFibonacci** - Even Fibonacci Numbers](./Sequences/EvenFibonacci.cs) - Filter Fibonacci
- [ ] [**BellNumber**](./Sequences/BellNumber.cs) - Partition counting
- [ ] [**CatlanNumber**](./Sequences/CatlanNumber.cs) - Important combinatorial number

Plus other sequence generators in the Sequences folder...

**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Recognize and generate mathematical patterns

---

### Phase 4: Data Structures Basics

Learn how to implement and use a basic data structure.

- [ ] [**Stack** - Basic Stack Implementation](./Stack/Stack.cs) - LIFO data structure (Last In, First Out)

**Time to spend**: 30-45 minutes  
**Key Takeaway**: Understand how to implement basic data structures

---

### Phase 5: Shuffling (Randomization)

Understand random ordering.

- [ ] [**FisherYatesShuffle** - Fisher-Yates Shuffle Algorithm](./Shufflers/FisherYatesShuffle.cs) - Perfectly random shuffle
- [ ] [**KnuthShuffle** - Knuth's variant of Fisher-Yates](./Shufflers/KnuthShuffle.cs)
- [ ] [**CocktailSorter** - Cocktail Sort (Two-way Bubble Sort)](./Shufflers/CocktailSorter.cs)

**Time to spend**: 30-45 minutes  
**Key Takeaway**: Randomization is important for many algorithms

---

### Phase 6: Pattern Matching Basics

- [ ] [**NaiveStringSearch** - Naive String Matching](./PatternMatching/NaiveStringSearch.cs) - Simple pattern search

**Time to spend**: 20-30 minutes  
**Key Takeaway**: Introduction to pattern matching (we'll do better in 200-level!)

---

## 🏆 Mastery Checklist

- [ ] Can explain why Factorial uses recursion
- [ ] Can implement Bubble Sort without looking it up
- [ ] Understand Big-O notation for O(n) and O(n²) algorithms
- [ ] Can build a simple stack
- [ ] Can explain what makes a string a palindrome
- [ ] Understand the difference between Arithmetic and Geometric sequences
- [ ] Know how Fisher-Yates shuffle works (and why it's good!)

---

## 💡 Tips for Learning at This Level

1. **Run the code** - Don't just read it, execute it with different inputs
2. **Modify and experiment** - Change algorithms and see what happens
3. **Write your own** - After understanding one sort, try writing another from scratch
4. **Understand before memorizing** - Don't memorize code, understand why it works
5. **Draw it out** - Use paper/whiteboard to trace through algorithms step-by-step

---

## 🚀 Next Steps

Once you've completed 100-level:
- Move to **200-level** for intermediate algorithms
- You'll learn faster searching (Binary Search)
- You'll learn faster sorting (Merge Sort, Quick Sort)
- You'll encounter your first complex data structures

---

## 📊 Algorithm Difficulty Reference

| Algorithm | Difficulty | Time Complexity | Space Complexity |
|-----------|-----------|-----------------|------------------|
| Factorial | ⭐ Very Easy | O(n) | O(1) or O(n) recursive |
| Linear Search | ⭐ Easy | O(n) | O(1) |
| Bubble Sort | ⭐⭐ Easy | O(n²) | O(1) |
| Insertion Sort | ⭐⭐ Easy | O(n²) | O(1) |
| Fibonacci | ⭐⭐ Easy | O(2ⁿ) naive | O(n) |
| String Palindrome | ⭐ Easy | O(n) | O(1) |

---

## 🔗 Resources

- **Understanding Big-O**: All algorithms have complexity measures. At 100-level, expect O(n) and O(n²)
- **Sorting Comparisons**: https://en.wikipedia.org/wiki/Comparison_sort
- **String Algorithms**: https://en.wikipedia.org/wiki/String-searching_algorithm

---

**Start with Abs.cs and work your way down. Good luck! 🎓**
