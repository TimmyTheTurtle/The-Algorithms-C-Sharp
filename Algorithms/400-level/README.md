# 400-Level Algorithms - Advanced/Senior CS

Welcome to **400-level algorithms**! These are senior-level and specialized algorithms typically found in Algorithms II, Advanced Optimization, or specialized electives (CS 401-499). These algorithms represent the cutting edge of algorithmic thinking—optimizations, advanced techniques, and sophisticated solutions to complex problems.

## 📚 Learning Objectives

By completing this level, you will understand:
- Advanced pathfinding and search (A* algorithm)
- Industrial-strength sorting (TimSort)
- Performance optimization techniques
- Specialized graph algorithms
- Advanced numeric algorithms
- State-of-the-art implementations

## ⚠️ Prerequisites

**Before starting 400-level, you MUST be comfortable with:**
- ALL 300-level algorithms
- Dynamic programming
- Graph algorithms (Dijkstra, MST, etc.)
- Time complexity analysis and optimization
- Advanced data structures (heaps, hash tables, trees)
- Big-O notation and practical optimization

---

## 🎯 Recommended Learning Sequence

### Phase 1: A* Pathfinding (Advanced Search)

A* is the gold standard for pathfinding in games, robotics, and navigation.

- [ ] [**AStarAlgorithm** - A* Pathfinding](./Search/AStar/AStarAlgorithm.cs) - Most efficient pathfinding with heuristics
- [ ] Other A* variants and implementations in Search/AStar/

**Prerequisite**: Dijkstra (300-level), understand heuristic functions  
**Time to spend**: 2-2.5 hours  
**Key Takeaway**: A* is Dijkstra + heuristic guidance. Massively faster for single-target pathfinding  
**Complexity**: O((V+E) log V) with good heuristic, but depends on heuristic quality  
**Real-world use**: 
- Game pathfinding (NPCs, AI)
- Robot navigation
- GPS route planning
- Puzzle solving (8-puzzle, Rubik's cube)

**Important Concepts**:
- **f(n) = g(n) + h(n)** where g = cost so far, h = heuristic estimate
- **Admissibility**: h(n) must never overestimate true cost
- **Consistency**: h(n) ≤ cost(n→n') + h(n')

---

### Phase 2: Advanced Sorting (Production-Quality)

#### 2.1 TimSort - Hybrid Algorithm

- [ ] [**TimSort** - Tim Sort Algorithm](./Comparison/TimSort.cs) - Python's sort, now in Java 7+, designed for real-world data
- [ ] [**GallopingStrategy** - Galloping Search](./Comparison/GallopingStrategy.cs) - Speed optimization within TimSort
- [ ] [**GallopingSort** - Galloping Sort](./Comparison/GallopingSort.cs)

**Prerequisite**: Merge Sort, Quick Sort, Insertion Sort (from earlier levels)  
**Time to spend**: 2-3 hours  
**Key Takeaway**: Industrial sorting combines multiple algorithms based on data characteristics  
**Why it matters**: TimSort is used in production by millions of developers  
**Complexity**:
- Best: O(n) on nearly-sorted data
- Average: O(n log n)
- Worst: O(n log n) - guaranteed!
- Space: O(n)

**Key Innovations**:
- Detects natural runs in data
- Switches between algorithms based on run length
- Galloping mode for merging sorted sequences
- Adaptive to real-world data patterns

---

### Phase 3: Other Advanced Sorting

- [ ] [**IntroSort** - Introspective Sort](./Comparison/IntroSort.cs) - Starts Quick Sort, switches to Heap Sort
- [ ] [**PatternDefeatSort** - PdqSort](./Comparison/PatternDefeatSort.cs) - Defeats adversarial patterns
- [ ] Additional specialized sorts in Comparison/

**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Different sorts for different scenarios and adversarial cases

---

### Phase 4: Advanced Numeric & Optimization

- [ ] Advanced numeric algorithms in Numeric/
- [ ] Optimization techniques
- [ ] Special-case numeric solutions

**Time to spend**: 1.5-2 hours

---

## 🏆 Mastery Checklist

- [ ] Can explain why A* is faster than Dijkstra for pathfinding
- [ ] Understand admissible and consistent heuristics
- [ ] Know when to use A* vs Dijkstra
- [ ] Can trace through A* algorithm by hand
- [ ] Understand why TimSort is preferred in production
- [ ] Know the difference between TimSort's best case and average case
- [ ] Can explain galloping mode and why it helps

---

## 💡 Key Concepts at This Level

**Heuristic Search**: Using problem-specific knowledge to guide search  
**Algorithm Hybridization**: Combining multiple algorithms for different scenarios  
**Adaptive Algorithms**: Adjusting behavior based on input characteristics  
**Practical Optimization**: Not just asymptotic complexity, but real-world performance  
**Implementation Details**: Cache efficiency, memory access patterns, constant factors matter

---

## 🎓 The A* Algorithm in Detail

### How A* Works

```
While open_set is not empty:
    current = node in open_set with lowest f(n)
    
    if current == goal:
        return path
    
    Remove current from open_set
    Add current to closed_set
    
    For each neighbor of current:
        if neighbor in closed_set:
            continue
        
        tentative_g = g(current) + cost(current → neighbor)
        
        if neighbor not in open_set:
            Add neighbor to open_set
        else if tentative_g >= g(neighbor):
            continue (found better path)
        
        g(neighbor) = tentative_g
        h(neighbor) = heuristic(neighbor → goal)
        f(neighbor) = g(neighbor) + h(neighbor)
```

### Why A* is Optimal

1. **Admissibility**: h(n) ≤ actual cost means we never prune optimal paths
2. **Completeness**: Will always find a path if one exists
3. **Optimality**: Will find the shortest path
4. **Efficiency**: Much faster than Dijkstra because heuristic guides search toward goal

### Heuristic Examples

**For Grid/Euclidean**: √((x₁-x₂)² + (y₁-y₂)²) - Euclidean distance  
**For Manhattan**: |x₁-x₂| + |y₁-y₂| - Manhattan distance  
**For 8-Puzzle**: Number of misplaced tiles  
**For Games**: Domain-specific estimates

---

## 📊 Complexity Comparison

| Algorithm | Time | Space | Best For |
|-----------|------|-------|----------|
| Dijkstra | O((V+E) log V) | O(V) | Unweighted/single-source |
| A* | O((V+E) log V) | O(V) | Single target, good heuristic |
| Bubble Sort | O(n²) | O(1) | Educational only |
| Quick Sort | O(n log n) avg | O(log n) | General purpose |
| Merge Sort | O(n log n) | O(n) | Guaranteed, stable |
| TimSort | O(n) best, O(n log n) avg | O(n) | Real-world data |
| Heap Sort | O(n log n) | O(1) | Worst-case guarantee |

---

## 🚀 Real-World Applications

### A* is used in:
- **Games**: Unity, Unreal Engine pathfinding
- **Navigation**: Google Maps, GPS systems
- **Robotics**: Path planning for robots
- **Puzzle Solvers**: Optimal solutions for sliding puzzles
- **Network Routing**: Some advanced routing protocols

### TimSort is used in:
- **Python**: Default sort since 2.3
- **Java**: Arrays.sort() since version 7
- **.NET**: Some implementations
- **Android**: Sorting algorithm
- **V8 (JavaScript)**: Sort implementation

---

## 💪 Challenge Problems

Once you understand A* and TimSort, try these:

1. **Implement A* for an 8-puzzle solver** - Find optimal solution
2. **Implement A* for a grid maze** - Handle obstacles
3. **Analyze TimSort performance** - Run on different data patterns
4. **Design a custom heuristic** - For a domain you know

---

## ⚠️ Important Notes

- **A* requires careful heuristic design** - Bad heuristics make it slower than Dijkstra
- **TimSort is complex** - Its true power comes from implementation details
- **Galloping mode is subtle** - Understand it deeply before implementing
- **This level is hard** - Spend time understanding, not just reading

---

## 🔗 Further Reading

- **A* Search Algorithm**: https://en.wikipedia.org/wiki/A*_search_algorithm
- **TimSort Analysis**: https://svn.python.org/projects/python/trunk/Objects/listsort.txt
- **Heuristic Functions**: https://en.wikipedia.org/wiki/Admissible_heuristic

---

**Start with AStarAlgorithm and work through the pathfinding problems. This is where algorithms meet real-world engineering! 🚀**
