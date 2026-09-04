# Copilot Instructions for The Algorithms - C#

## Overview

This is an educational repository of algorithms in C# organized by Computer Science curriculum complexity levels (100/200/300/400-level plus specialized). The goal is to implement algorithms clearly with full documentation, comprehensive tests, and optionally educational visualizations (Jupyter notebooks for Python-based exploration).

## Project Structure

### Main Projects (C#)
- **`Algorithms/`** - Core algorithm implementations organized by level
  - `100-level/` (43 algorithms) - Introductory: strings, basic sorting, numeric operations
  - `200-level/` (96 algorithms) - Intermediate: advanced sorting, graph algorithms, encoders
  - `300-level/` (71 algorithms) - Advanced: shortest paths, dynamic programming, complex algorithms
  - `400-level/` (22 algorithms) - Senior-level: specialized and optimized algorithms
  - `specialized/` (21 algorithms) - Domain-specific: crypto, machine learning, financial, recommender systems
- **`Algorithms.Tests/`** - NUnit test suite (229 test files)
- **`DataStructures/`** - Supporting data structures (also has matching `.Tests` project)
- **`Utilities/`** - Helper utilities (also has matching `.Tests` project)
- **`notebooks/`** - Jupyter notebooks (Python) for interactive visualizations and learning

## Build, Test, and Run

### Build the Solution
```bash
dotnet build C-Sharp.sln
```

### Run All Tests
```bash
dotnet test C-Sharp.sln
```

### Run Tests for a Single Project
```bash
dotnet test Algorithms.Tests/Algorithms.Tests.csproj
dotnet test DataStructures.Tests/DataStructures.Tests.csproj
```

### Run a Single Test File
```bash
dotnet test Algorithms.Tests/Algorithms.Tests.csproj --filter "BubbleSorterTests"
```

### Run Tests with Code Coverage
```bash
dotnet test C-Sharp.sln --collect:"XPlat Code Coverage"
```

### Build Without Tests (Quick Build)
```bash
dotnet build C-Sharp.sln --no-test-on-build
```

### Watch Mode (for continuous rebuilding)
```bash
dotnet watch --project Algorithms/Algorithms.csproj build
```

## Code Style & Conventions

### Language & Target
- **Language:** C# (modern syntax encouraged)
- **Target Framework:** .NET 8.0
- **Nullable Reference Types:** Enabled (`<Nullable>enable</Nullable>`)
- **Treat Warnings as Errors:** True (code must compile without warnings)

### StyleCop Rules
- **Indentation:** Spaces (4 spaces), no tabs
- **Using Directives:** Placed outside namespace, omit blank lines between groups
- **File Endings:** Require newline at end of file
- Full StyleCop.Analyzers v1.2 enforcement (see `stylecop.ruleset`)

### Naming & Documentation
- **XML Documentation:** Required on public methods and classes
  - Use `<summary>`, `<param>`, `<returns>`, `<typeparam>` tags
  - Include time/space complexity comments in algorithm implementations
  - Example: `/// <summary>Sorts array in-place. Time: O(n²), Space: O(1)</summary>`
- **Class Names:** PascalCase (e.g., `BubbleSorter`, `GeneralStringAlgorithms`)
- **Method Names:** PascalCase
- **Private Fields:** camelCase with underscore prefix (e.g., `_maxValue`)
- **Local Variables:** camelCase (e.g., `currentIndex`)

### Generic Implementation Pattern
Most algorithms use **generics with IComparer<T>**:
```csharp
public class BubbleSorter<T> : IComparisonSorter<T>
{
    public void Sort(T[] array, IComparer<T> comparer)
    {
        // Implementation
    }
}
```

### Algorithm Documentation Standards
Include in algorithm classes:
1. Class-level XML summary explaining the algorithm
2. Method XML documentation with complexity analysis
3. Complexity comments: `time complexity: O(n^2), space complexity: O(1)`
4. Property notes: `internal, in-place, stable` (or relevant descriptors)

## Testing Conventions

### Framework & Tools
- **Test Framework:** NUnit 4.0+
- **Mocking:** Moq
- **Assertions:** FluentAssertions for readable assertions
- **Coverage:** Coverlet (automatically collected in test runs)

### Test Organization
- Test files mirror source structure: `Algorithms.Tests/{category}/{AlgorithmName}Tests.cs`
- Test classes are `static` with `[Test]` decorated static methods
- Each test uses **Arrange-Act-Assert** pattern (see comments)
- Example: `BubbleSorterTests.cs` tests `BubbleSorter<T>`

### Test Data Generation
- Use `[Random(min, max, count, Distinct)]` for parameterized random tests
- Use `RandomHelper.GetArrays(n)` to generate paired correct/test arrays
- Use `IntComparer` helper for integer comparison tests

### Naming Tests
- Use descriptive names reflecting what's being tested
- Example: `ArraySorted`, `ShouldThrowOnNullInput`, `FindsLongestSequence`

## Architecture Patterns

### Sorter Interfaces
- `IComparisonSorter<T>` - Sorts with custom comparers
- `IRadixSorter` - Non-comparison sorting
- Sorters typically implement generics and work with any type

### Searcher Pattern
- Generic searchers: `BinarySearcher<T>`, `LinearSearcher<T>`
- Return type varies: `int` for index, or nullable/tuple for more complex results
- Example: `LinearSearcher<T>.FindIndex(T[] array, T target, IComparer<T> comparer)`

### Sequence Pattern
- Implement `ISequence` interface
- Generate sequences on-demand (lazy evaluation preferred where practical)
- Examples: `FibonacciSequence`, `NaturalSequence`

### Graph Algorithms
- Typically work with adjacency lists or matrices
- Return results as collections or boolean/single values
- Include cycle detection, connectivity, or traversal methods

## Key Dependencies

### NuGet Packages
- **SkiaSharp** (v2.88.8) - Graphics/visualization support (optional, for visual algorithms)
- **StyleCop.Analyzers** (v1.2.0-beta) - Code style enforcement
- **NUnit** (v4.0.1) - Testing framework
- **FluentAssertions** (v6.12.0) - Assertion library
- **Moq** (v4.20.72) - Mocking framework
- **Coverlet.Collector** (v6.0.0) - Code coverage

### Project References
- `Algorithms` references: `DataStructures`, `Utilities`
- Test projects reference their corresponding implementation projects

## Common Tasks

### Add a New Algorithm
1. Create file in appropriate complexity level (e.g., `Algorithms/100-level/Strings/MyAlgorithm.cs`)
2. Implement with full XML documentation including complexity analysis
3. Follow generic + comparer pattern if applicable
4. Create corresponding test file: `Algorithms.Tests/Strings/MyAlgorithmTests.cs`
5. Run `dotnet test` to ensure all tests pass
6. Rebuild solution to verify StyleCop compliance

### Rename or Reorganize
- Maintain namespace structure matching folder hierarchy
- Update any test file references
- Run full test suite to catch reference breakage

### Fix Compiler Warnings
- All warnings are treated as errors
- Common issues: unused variables, non-nullable values, missing documentation
- Fix immediately; do not suppress with `#pragma`

## Educational Context (LLM Augmentation Curriculum)

This repository supports **neurosymbolic AI expertise mastery**. You're building deterministic algorithms that provide the structure, constraints, and optimization logic to guide and augment LLM reasoning.

The curriculum sequences algorithms from simple to complex, where each phase builds capability toward real-world neurosymbolic AI applications:

- **Phase 1 (Weeks 1-2):** Strings and sorting fundamentals → Data transformation and efficiency thinking
- **Phase 2 (Weeks 2-3):** Search algorithms (linear, binary, exponential) → How agents explore option spaces
- **Phase 3 (Weeks 3-4):** Graph representation and traversal (DFS, BFS, topological sort) → Reasoning through dependencies and relationships
- **Phase 4 (Weeks 4-5):** Shortest path and optimization (Dijkstra, Bellman-Ford) → Cost-aware reasoning and resource constraints
- **Phase 5+:** Advanced algorithms, DP, specialized domains → Real-world neurosymbolic applications

See `LLM_AUGMENTATION_CURRICULUM.md` for full learning progression and time estimates, and `LEARNING_PROGRESS.md` for current mastery level and skill assessment.

## Jupyter Notebooks (Python Visualizations)

- Located in `notebooks/` directory
- Used for interactive exploration and visualization (e.g., sorting animations, algorithm step-by-step walkthroughs)
- Environment: `algorithms-env` virtual environment
- Dependencies: numpy, matplotlib, plotly (managed separately from C# project)
- Not part of the C# build/test pipeline; used for learning and visualization only

## PR/Commit Standards

- Commit messages should reference the algorithm name and what was done (e.g., "Add BubbleSort algorithm with tests")
- Include complexity analysis comments in algorithm methods
- Ensure all tests pass before committing
- No uncommitted StyleCop violations
