# Code Assessment: 100-Level Strings and Numeric Foundations

**Last Updated:** 2026-09-07  
**Reviewed Work:** All current implementations in `100-level-strings.ipynb` and the recursive `factorial` implementation in `100-level-numeric.ipynb`

---

## Overall Assessment

You are demonstrating real algorithmic habits rather than merely filling in templates: you choose suitable data structures, write loops that match the problem, and test normal and boundary cases. The next gain comes from making the stated contract, implementation, and example expectations agree exactly.

## Demonstrated Strengths

1. **You select appropriate representations.** The reverse-string solution builds a character list and joins it once; the vowel reversal converts to a mutable list; character counting uses a dictionary. Those choices fit their jobs.

2. **You use loop boundaries carefully.** The manual reverse begins at `len(s) - 1` and stops after index `0`. The palindrome and two-pointer vowel-reversal loops stop when the pointers meet. The substring search correctly includes the last possible starting position with `len(text) - len(substring) + 1`.

3. **You handle several important boundaries.** The palindrome, frequency count, substring search, anagram detection, and factorial implementations have meaningful empty, single-value, or base-case coverage in their examples.

4. **You can compare alternative approaches.** The recursive and iterative factorial implementations provide a useful, concrete comparison: both perform O(n) multiplications, while the recursive version also uses O(n) call-stack space and the iterative version uses O(1) auxiliary space.

5. **You are beginning to reason about constraints.** `highest_frequency_single_pass` maintains the current maximum while counting, avoiding a second sorting pass. That is the right structural response to a single-pass requirement.

## Algorithm Review

| Algorithm | Assessment | Evidence and next correction |
|---|---|---|
| Manual string reversal | Correct | Produces a reversed copy in O(n) time and O(n) space. |
| Vowel-only reversal | Implementation is correct; examples are not | The function reverses only vowels, but several expected-output comments describe a full-string reversal. For example, `"hello"` should become `"holle"`, not `"olleh"`. Align the examples with the function contract. |
| Palindrome check | Correct for its stated rule | It ignores spaces and case as documented. It intentionally does not ignore punctuation; decide whether that is the desired contract and state it clearly. |
| Character frequency count | Correct | `counts[character] = counts.get(character, 0) + 1` is the appropriate one-pass dictionary pattern. |
| Highest frequency with sorting | Correct, with a complexity trade-off | Counting is O(n), then sorting distinct characters costs O(k log k). It returns `None` for an empty input, which is explicit and sensible. |
| Highest frequency, single pass | Correctly tracks a maximum; tie rule needs correction | With `>=`, a later character replaces an earlier character when they tie. That is a valid policy, but it selects the most recently reaching character, not the first. Use `>` to keep the first character that reaches the maximum, or document the deliberate last-tie-wins rule. |
| Linear substring search | Correct | The loop bound includes the final valid candidate position and naturally returns `0` for an empty substring. |
| Anagram detection | Partially meets its documented contract | Counting and comparing is correct for exact-character anagrams. The docstring says case-insensitive and space-ignoring, but the implementation does neither. Normalize both inputs before counting, or narrow the docstring. Remove the unnecessary trailing semicolon after the second dictionary update. |
| Manual case conversion | Correct for ASCII English letters | The range checks and `ord`/`chr` conversions work for A-Z and a-z. The top-level `case_span` is a helpful named constant; `ASCII_CASE_OFFSET` would communicate its meaning more precisely. |
| Vowel and consonant count | Correct for ASCII letters | It correctly excludes digits and punctuation. The implementation would be clearer with `character.isalpha()` and a vowel set, or by naming the numeric boundaries in uppercase constant style if the ASCII exercise is intentional. |
| Recursive factorial | Correct for non-negative integers | The base cases and recurrence are correct. Add a guard for negative inputs so they raise a clear error rather than recursing until Python reaches its recursion limit. The timing comparison is a good experiment, but very small calls are too fast for one measurement to be meaningful; repeat a workload before comparing timings. |

## Coding Habits to Strengthen

1. **Treat comments and examples as part of correctness.** A function whose implementation is right but whose examples promise something else still teaches the wrong thing. Verify expected results against the exact contract.

2. **Make tie-breaking policies explicit.** `>` versus `>=` is not cosmetic: it chooses a different winner. State the intended rule and test a tie.

3. **Validate inputs at algorithm boundaries.** Your factorial function has a natural domain: non-negative integers. Enforce it directly so invalid use fails clearly.

4. **Prefer names that reveal intent once a solution grows.** Short names such as `s` and `c` are reasonable in tiny functions. Names like `character`, `maximum_character`, and `consonant_count` are easier to review in longer exercises.

5. **Separate learning mechanics from production clarity.** Using ASCII values is worthwhile for understanding case conversion. After learning it, compare it with Python's built-in methods and explain the behavioral difference, especially for non-ASCII text.

## Recommended Next Focus

Finish the numeric sequence by implementing Fibonacci, GCD, primality testing, and modular exponentiation. For each one, begin by writing its input contract and two edge cases before writing the main loop or recursion.
