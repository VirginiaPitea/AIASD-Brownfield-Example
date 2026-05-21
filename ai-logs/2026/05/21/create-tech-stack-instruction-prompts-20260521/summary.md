# Session Summary: Tech Stack Instruction Prompt Set

**Session ID**: create-tech-stack-instruction-prompts-20260521
**Date**: 2026-05-21
**Operator**: github-copilot
**Model**: openai/gpt-5.3-codex@unknown
**Duration**: 00:30:00

## Objective

Create reusable prompt files that generate technology-specific `.instructions.md` files for the repository's active stack.

## Work Completed

### Primary Deliverables

1. **Tech-stack meta prompt files** (`.github/prompts/meta/`)
   - Added prompts for dotnet, csharp, aspnetcore, efcore, automapper, xunit, json, libman, and html.
   - Aligned structure to existing promptfile conventions.
   - Included provenance metadata and prompt metadata in each file.

2. **Chat provenance log** (`ai-logs/2026/05/21/create-tech-stack-instruction-prompts-20260521/`)
   - Created `conversation.md` and `summary.md`.
   - Recorded objectives, outcomes, and artifact list.

3. **Traceability update** (`README.md`)
   - Added artifact entries and ai-log link for this work burst.

## Key Decisions

### Prompt Granularity

**Decision**: Create one prompt per technology instead of one large template.
**Rationale**:

- Keeps each prompt focused and easier to run independently.
- Reduces accidental cross-technology boilerplate in generated instructions.

### Metadata Consistency

**Decision**: Use one chat ID and ai-log path across all created prompt artifacts.
**Rationale**: Maintains a single traceable provenance chain for this request.

## Artifacts Produced

| Artifact                                                                     | Type       | Purpose                              |
| ---------------------------------------------------------------------------- | ---------- | ------------------------------------ |
| `.github/prompts/meta/create-dotnet-instructions.instructions.prompt.md`     | Promptfile | Generate dotnet instruction file     |
| `.github/prompts/meta/create-csharp-instructions.instructions.prompt.md`     | Promptfile | Generate csharp instruction file     |
| `.github/prompts/meta/create-aspnetcore-instructions.instructions.prompt.md` | Promptfile | Generate aspnetcore instruction file |
| `.github/prompts/meta/create-efcore-instructions.instructions.prompt.md`     | Promptfile | Generate efcore instruction file     |
| `.github/prompts/meta/create-automapper-instructions.instructions.prompt.md` | Promptfile | Generate automapper instruction file |
| `.github/prompts/meta/create-xunit-instructions.instructions.prompt.md`      | Promptfile | Generate xunit instruction file      |
| `.github/prompts/meta/create-json-instructions.instructions.prompt.md`       | Promptfile | Generate json instruction file       |
| `.github/prompts/meta/create-libman-instructions.instructions.prompt.md`     | Promptfile | Generate libman instruction file     |
| `.github/prompts/meta/create-html-instructions.instructions.prompt.md`       | Promptfile | Generate html instruction file       |

## Next Steps

### Immediate

- Execute each prompt once and review generated instruction file quality.
- Tune wording for repo-specific conventions where needed.

### Future Enhancements

- Add prompts for JWT/auth and architecture-specific instruction sets.

## Compliance Status

✅ Conversation log created
✅ Summary file created
✅ Artifact provenance metadata included
✅ README traceability updated

## Chat Metadata

```yaml
chat_id: create-tech-stack-instruction-prompts-20260521
started: 2026-05-21T00:00:00Z
ended: 2026-05-21T00:30:00Z
total_duration: 00:30:00
operator: github-copilot
model: openai/gpt-5.3-codex@unknown
artifacts_count: 9
files_modified: 12
```
