# C# Learning Progress

## Current Position
- **Stage:** A — C# Language Mastery
- **Phase:** 1 — Core Language Foundations
- **Topic:** Operators, control flow, pattern matching in `switch` (modern style) — up next

---

## Completed Topics
- 2026-07-10 — Phase 0: SDK vs Runtime, `dotnet` CLI (new/run/build/watch), IL/CLR/JIT mental model, `.sln`/`.slnx` vs `.csproj` read line-by-line
- 2026-07-11 — Phase 1: Program structure (top-level statements vs `Main`), file-scoped namespaces, `using`, one-compilation-unit-per-entry-point rule (CS8802), assembly vs repository/InternalsVisibleTo, access modifiers (`public`/`internal`), static vs instance design decision, C# naming conventions (camelCase/_camelCase/PascalCase)
- 2026-07-11 — Phase 1: Value types vs reference types, stack vs heap, mutate-through-reference vs reassign-the-local-pointer distinction, "pass by value" applied to reference types, boxing/unboxing (concept only)
- 2026-07-11 — Phase 1: Built-in types (int/long/double/decimal/bool/char), `int` vs `System.Int32`, `var` as compile-time inference (not dynamic typing), decimal vs double for money, implicit vs explicit conversion, `checked`/`unchecked` and silent integer overflow, never ignore compiler warnings
- 2026-07-11 — Phase 1: String immutability (methods return new strings, don't mutate), `+=` concat vs `StringBuilder` perf (measured: ~37ms vs 0ms over 10k iterations), string `==` is value equality (overloaded) vs `ReferenceEquals`
- 2026-07-11 — Phase 1: Nullability — `int?`/`Nullable<T>`, nullable reference types (`string?`), compiler static-analysis flow tracking, live `CS8602` warning read and fixed properly (not suppressed with `!`), `??` and `.HasValue`, PascalCase applies to local functions too

---

## Struggle List (Revisit)
- Naming conventions (used snake_case initially — corrected, watch for recurrence since it's a habit from another language background)
- Initially described reference-passing as "deep copy" — corrected to "pointer/address copy"; re-quiz this later to confirm it stuck

---

## Pending Tasks
_(none yet)_

---

## Session Log
| Date       | Topics Covered                          |
|------------|------------------------------------------|
| 2026-07-10 | Phase 0 complete: SDK/runtime, dotnet CLI, IL/CLR/JIT, .csproj/.slnx anatomy. `CSharpMastery` solution created with `Phase1.Foundations` project. |
| 2026-07-11 | Phase 1 started: top-level statements, namespaces, using, entry-point rule, assemblies vs repos, access modifiers, static vs instance, naming conventions. Built/reviewed `Greeter` class through 2 PR-review rounds. |
