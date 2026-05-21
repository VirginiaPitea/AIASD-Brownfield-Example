# AI Conversation Log

- Chat ID: create-tech-stack-instruction-prompts-20260521
- Operator: github-copilot
- Model: openai/gpt-5.3-codex@unknown
- Started: 2026-05-21T00:00:00Z
- Ended: 2026-05-21T00:30:00Z
- Total Duration: 00:30:00

## Context

- Inputs: Existing promptfile conventions, instruction files, repository tech stack
- Targets: Tech-stack instruction-generator prompt files under .github/prompts/meta/
- Constraints/Policies: .github/instructions/ai-assisted-output.instructions.md, .github/instructions/prompt-file.instructions.md

## Exchanges

### Exchange 1

[2026-05-21T00:00:00Z] user

```text
create prompts for creating instrucion files for the tech stack
```

[2026-05-21T00:30:00Z] assistant

```text
Created a set of technology-specific meta prompt files for generating instruction files.
Added required ai-log artifacts and updated README traceability links.
```

## Work Burst Closure

**Artifacts Produced**:

- .github/prompts/meta/create-dotnet-instructions.instructions.prompt.md - Dotnet instruction-generation prompt
- .github/prompts/meta/create-csharp-instructions.instructions.prompt.md - Csharp instruction-generation prompt
- .github/prompts/meta/create-aspnetcore-instructions.instructions.prompt.md - Aspnetcore instruction-generation prompt
- .github/prompts/meta/create-efcore-instructions.instructions.prompt.md - Efcore instruction-generation prompt
- .github/prompts/meta/create-automapper-instructions.instructions.prompt.md - Automapper instruction-generation prompt
- .github/prompts/meta/create-xunit-instructions.instructions.prompt.md - Xunit instruction-generation prompt
- .github/prompts/meta/create-json-instructions.instructions.prompt.md - Json instruction-generation prompt
- .github/prompts/meta/create-libman-instructions.instructions.prompt.md - Libman instruction-generation prompt
- .github/prompts/meta/create-html-instructions.instructions.prompt.md - Html instruction-generation prompt

**Next Steps**:

- [ ] Run each new prompt and validate generated instruction outputs.
- [ ] Extend prompt set for additional technologies if stack evolves.

**Duration Summary**:

- prompt authoring: 00:24:00
- provenance and traceability updates: 00:06:00
- Total: 00:30:00
