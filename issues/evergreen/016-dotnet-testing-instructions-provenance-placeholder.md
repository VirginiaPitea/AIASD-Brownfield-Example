# Issue: dotnet-testing Instruction File Has Unresolved Provenance Placeholders

## Severity

Low

## Description

The `.github/instructions/dotnet-testing.instructions.md` metadata still includes placeholder values like `<copilot-chat-id>`.

Unresolved provenance placeholders reduce instruction traceability and repository auditability.

## Proposed Updates

1. Replace placeholder `chat_id` with actual identifier.
2. Replace placeholder `ai_log` path with actual conversation log path.
3. Validate that linked log file exists.
4. Keep metadata formatting consistent with repository provenance policy.

## Verification Steps

1. Update metadata values in instruction file.
2. Open referenced `ai_log` path and confirm file exists.
3. Run repository search for `<copilot-chat-id>` to ensure no leftover placeholder in finalized instruction files.
