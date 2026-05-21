---
name: create-xunit-instructions
description: Generate or update xUnit instruction guidelines for unit and controller-level tests in this repository.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "xunit", "testing"]
ai_generated: true
model: "openai/gpt-5.3-codex@unknown"
operator: "github-copilot"
chat_id: "create-tech-stack-instruction-prompts-20260521"
prompt: |
  create prompts for creating instruction files for the tech stack
started: "2026-05-21T00:00:00Z"
ended: "2026-05-21T00:00:00Z"
task_durations:
  - task: "prompt authoring"
    duration: "00:03:00"
total_duration: "00:03:00"
ai_log: "ai-logs/2026/05/21/create-tech-stack-instruction-prompts-20260521/conversation.md"
source: "github-copilot-chat"
owner: "Development Team"
version: "1.0.0"
prompt_metadata:
  id: create-xunit-instructions
  title: Create Xunit Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/xunit.instructions.md
  category: documentation
  output_format: markdown
---

# Create Xunit Instructions

## Context

Create or update `.github/instructions/xunit.instructions.md` using the current test project structure and test naming patterns.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Provide practical xUnit guidance for deterministic, readable tests that validate controller/service behavior and authorization rules.

## Deliverable

Generate `.github/instructions/xunit.instructions.md` with:

1. Full provenance front matter.
2. Rules for test structure, Arrange/Act/Assert clarity, and naming conventions.
3. Guidance for mock boundaries and integration-vs-unit split.
4. Guidance for failure diagnostics and regression coverage.
5. Validation checklist.

## Output Format

Return the full Markdown instruction file.
