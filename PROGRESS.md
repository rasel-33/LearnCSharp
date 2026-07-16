# C# Learning Progress

## Current Position
- **Stage:** A — C# Language Mastery
- **Phase:** 1 — Core Language Foundations — ✅ **COMPLETE** (incl. capstone)
- **Topic:** Next up → **Phase 2 — Object-Oriented C#** (classes, properties/`init`, constructors, `static`, encapsulation, inheritance, abstract vs interface, polymorphism, `Equals`/`GetHashCode`/`ToString`, records, composition, SOLID)

---

## Completed Topics
- 2026-07-10 — Phase 0: SDK vs Runtime, `dotnet` CLI (new/run/build/watch), IL/CLR/JIT mental model, `.sln`/`.slnx` vs `.csproj` read line-by-line
- 2026-07-11 — Phase 1: Program structure (top-level statements vs `Main`), file-scoped namespaces, `using`, one-compilation-unit-per-entry-point rule (CS8802), assembly vs repository/InternalsVisibleTo, access modifiers (`public`/`internal`), static vs instance design decision, C# naming conventions (camelCase/_camelCase/PascalCase)
- 2026-07-11 — Phase 1: Value types vs reference types, stack vs heap, mutate-through-reference vs reassign-the-local-pointer distinction, "pass by value" applied to reference types, boxing/unboxing (concept only)
- 2026-07-11 — Phase 1: Built-in types (int/long/double/decimal/bool/char), `int` vs `System.Int32`, `var` as compile-time inference (not dynamic typing), decimal vs double for money, implicit vs explicit conversion, `checked`/`unchecked` and silent integer overflow, never ignore compiler warnings
- 2026-07-11 — Phase 1: String immutability (methods return new strings, don't mutate), `+=` concat vs `StringBuilder` perf (measured: ~37ms vs 0ms over 10k iterations), string `==` is value equality (overloaded) vs `ReferenceEquals`
- 2026-07-11 — Phase 1: Nullability — `int?`/`Nullable<T>`, nullable reference types (`string?`), compiler static-analysis flow tracking, live `CS8602` warning read and fixed properly (not suppressed with `!`), `??` and `.HasValue`, PascalCase applies to local functions too
- 2026-07-14 — Phase 1: **Methods** — pass-by-value as the default (value type copies data, reference type copies the reference → "the reference is passed by value", NOT "pass by reference"); `ref` (true two-way alias, keyword required at both declaration and call site), `out` (`TryParse` idiom, must assign on every path, out-var leaks to enclosing scope), `in` (read-only ref, perf for large structs). Optional params (compile-time-constant defaults, baked into caller → cross-assembly staleness trap), named args (skip middle optionals, kill boolean-literal mystery at call sites), overloading (differ by params, can't overload on return type). Design judgment: `bool`+`out` is lossy — collapses all failure reasons to one bit; use result type / exception when failure carries info. Built `TryDivide`, `Swap`, `Send` (optional/named), `Describe` overloads in `Describer.cs`.
- 2026-07-16 — Phase 1: **Arrays** — fixed-size + reference type (even `int[]`), 3 initializer forms, zero/`null` default-init trap (`new string[3]` = 3 nulls → NRE), `.Length` is a property, bounds checking (`IndexOutOfRangeException`, last valid index = `Length-1`), integer-division trap avoided via `(double)sum / count` cast placement. `Span<T>` seed only ("zero-copy view over contiguous memory"). Jagged `[][]` vs rectangular `[,]` recognition. 
- 2026-07-16 — Phase 1: **CAPSTONE — Expense Tracker CLI** (`Phase1.CliApplication`). Menu loop + `switch` statement, parallel `decimal[]`/`string[]` + `int count`, `decimal.TryParse`, capacity guard, `:F2` money formatting, all input paths guarded. Built over 3 build rounds. Verified end-to-end with scripted stdin. ✅ Phase 1 complete.
- 2026-07-14 — Phase 1: **Methods** — pass-by-value as the default (value type copies data, reference type copies the reference → "the reference is passed by value", NOT "pass by reference"); `ref` (true two-way alias, keyword required at both declaration and call site), `out` (`TryParse` idiom, must assign on every path, out-var leaks to enclosing scope), `in` (read-only ref, perf for large structs). Optional params (compile-time-constant defaults, baked into caller → cross-assembly staleness trap), named args (skip middle optionals, kill boolean-literal mystery at call sites), overloading (differ by params, can't overload on return type). Design judgment: `bool`+`out` is lossy — collapses all failure reasons to one bit; use result type / exception when failure carries info. Built `TryDivide`, `Swap`, `Send` (optional/named), `Describe` overloads in `Describer.cs`.
- 2026-07-12 — Phase 1: Operators & control flow — `&&`/`||` short-circuit vs `&`/`|` (correctness tool, null-guard pattern), ternary as an expression. **`switch` expressions** (modern style): value-before-`switch`, `pattern => result` arms, relational patterns (`<`, `<=`), `and`/`or`/`not` combinators, discard `_`, first-match-wins ordering, exhaustiveness. Expression-bodied methods (`=>`). Built `DescribeTemperature` switch-expression through 3 PR rounds.

---

## Struggle List (Revisit)
- Naming conventions (used snake_case initially — corrected, watch for recurrence since it's a habit from another language background)
- Initially described reference-passing as "deep copy" — corrected to "pointer/address copy"; re-quizzed 2026-07-12, answered correctly (pointer copy, mutate-through vs reassign) — looking solid, spot-check occasionally
- Refactor introduced an off-by-one boundary bug: changed `< 0` to `<= 0` on autopilot when collapsing redundant switch bounds. Lesson reinforced: **test the edges (0, 15, 16, 35), not the middles.** Watch for autopilot `<`↔`<=` changes during refactors.
- Interview articulation (not understanding): gave vague answers on (a) `decimal` vs `double` — must name binary-vs-base-10 float + accumulating rounding error; (b) `&&` as a correctness/null-guard tool, not just perf. Concepts are solid; precision of wording needs work. Re-quiz phrasing later.
- **Terminology:** called the default reference-type passing "pass by reference" — corrected to **"the reference is passed by value"** (copy of the pointer). Watch for recurrence; it's the exact phrasing interviewers probe.
- **Articulation:** could not put the `bool`+`out` design flaw into words unprompted (pasted the code instead of answering). Once shown "the caller *guessed* the failure reason," it landed. The concept — a `bool` erases *why* it failed — needs to become sayable, not just recognizable.
- **Quality habit:** typo `urget` in a parameter name — reinforced that parameter names are public contract (named-arg call sites freeze them; renaming is a breaking change). Watch for typos in identifiers.
- **⚠️ `try/catch` as a band-aid (capstone):** reached for `try/catch` to silence a `CS8601` nullability warning — wrong on two counts: (a) assigning null to a `string` slot doesn't *throw*, so the catch guarded nothing & the warning stayed; (b) exception-as-control-flow for a predictable condition (empty input) is a smell. Correct fix was `Console.ReadLine() ?? ""`. **Principle to reinforce in Phase 4: exceptions are for the unexpected, not ordinary conditions.** Watch for this reflex recurring.
- **Declare-before-use reflex:** wrote `runCli = true;` with no type declaration (CS0103) — autopilot from a dynamically-typed language. Also left a dead `= 0` initializer on `average`. Minor, but watch the "assign creates the variable" habit.

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
| 2026-07-14 | Phase 1: **Methods** — pass-by-value default (reference-passed-by-value vs true `ref`), `ref`/`out`/`in`, optional/named args, overloading, `bool`+`out` design trade-off. Built `TryDivide`, `Swap`, `Send`, `Describe` overloads — all correct & running. Corrected "pass by reference" terminology; flagged `urget` param typo (public contract). Pending: fix typo, cover `out`-failure articulation in a later quiz. |
| 2026-07-16 | Phase 1: **Arrays** (fixed-size ref type, default-init trap, bounds, int-division cast) + `Span<T>` seed. **CAPSTONE: Expense Tracker CLI** built & verified end-to-end over 3 build rounds. Key teachable: `try/catch` misused to silence a nullability warning → corrected to `?? ""` (exception-as-control-flow smell). **Phase 1 COMPLETE — Phase 2 (OOP) is next.** |
