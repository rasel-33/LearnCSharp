# C# Learning Progress

## Current Position
- **Stage:** A — C# Language Mastery
- **Phase:** 1 — Core Language Foundations
- **Topic:** Methods — parameters, `ref`/`out`/`in`, optional/named args, overloading — up next

---

## Completed Topics
- 2026-07-10 — Phase 0: SDK vs Runtime, `dotnet` CLI (new/run/build/watch), IL/CLR/JIT mental model, `.sln`/`.slnx` vs `.csproj` read line-by-line
- 2026-07-11 — Phase 1: Program structure (top-level statements vs `Main`), file-scoped namespaces, `using`, one-compilation-unit-per-entry-point rule (CS8802), assembly vs repository/InternalsVisibleTo, access modifiers (`public`/`internal`), static vs instance design decision, C# naming conventions (camelCase/_camelCase/PascalCase)
- 2026-07-11 — Phase 1: Value types vs reference types, stack vs heap, mutate-through-reference vs reassign-the-local-pointer distinction, "pass by value" applied to reference types, boxing/unboxing (concept only)
- 2026-07-11 — Phase 1: Built-in types (int/long/double/decimal/bool/char), `int` vs `System.Int32`, `var` as compile-time inference (not dynamic typing), decimal vs double for money, implicit vs explicit conversion, `checked`/`unchecked` and silent integer overflow, never ignore compiler warnings
- 2026-07-11 — Phase 1: String immutability (methods return new strings, don't mutate), `+=` concat vs `StringBuilder` perf (measured: ~37ms vs 0ms over 10k iterations), string `==` is value equality (overloaded) vs `ReferenceEquals`
- 2026-07-11 — Phase 1: Nullability — `int?`/`Nullable<T>`, nullable reference types (`string?`), compiler static-analysis flow tracking, live `CS8602` warning read and fixed properly (not suppressed with `!`), `??` and `.HasValue`, PascalCase applies to local functions too
- 2026-07-12 — Phase 1: Operators & control flow — `&&`/`||` short-circuit vs `&`/`|` (correctness tool, null-guard pattern), ternary as an expression. **`switch` expressions** (modern style): value-before-`switch`, `pattern => result` arms, relational patterns (`<`, `<=`), `and`/`or`/`not` combinators, discard `_`, first-match-wins ordering, exhaustiveness. Expression-bodied methods (`=>`). Built `DescribeTemperature` switch-expression through 3 PR rounds.

---

## Struggle List (Revisit)
- Naming conventions (used snake_case initially — corrected, watch for recurrence since it's a habit from another language background)
- Initially described reference-passing as "deep copy" — corrected to "pointer/address copy"; re-quizzed 2026-07-12, answered correctly (pointer copy, mutate-through vs reassign) — looking solid, spot-check occasionally
- Refactor introduced an off-by-one boundary bug: changed `< 0` to `<= 0` on autopilot when collapsing redundant switch bounds. Lesson reinforced: **test the edges (0, 15, 16, 35), not the middles.** Watch for autopilot `<`↔`<=` changes during refactors.
- Interview articulation (not understanding): gave vague answers on (a) `decimal` vs `double` — must name binary-vs-base-10 float + accumulating rounding error; (b) `&&` as a correctness/null-guard tool, not just perf. Concepts are solid; precision of wording needs work. Re-quiz phrasing later.

---

## Pending Tasks
_(none yet)_

---

## Session Log
| Date       | Topics Covered                          |
|------------|------------------------------------------|
| 2026-07-10 | Phase 0 complete: SDK/runtime, dotnet CLI, IL/CLR/JIT, .csproj/.slnx anatomy. `CSharpMastery` solution created with `Phase1.Foundations` project. |
| 2026-07-11 | Phase 1 started: top-level statements, namespaces, using, entry-point rule, assemblies vs repos, access modifiers, static vs instance, naming conventions. Built/reviewed `Greeter` class through 2 PR-review rounds. |
| 2026-07-12 | Phase 1: operators (`&&`/`&` short-circuit), `switch` expressions + relational/`and`/`or` patterns, expression-bodied methods. Built `DescribeTemperature` (3 PR rounds — collapsed redundant bounds, caught off-by-one at `0`, converted to `=>` body). 5-question spaced-rep quiz: 3 solid, 2 needed articulation polish (`decimal` vs `double`, `&&` correctness). |
