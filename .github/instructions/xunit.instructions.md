---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "workspace-core-tech-xunit-20260518"
prompt: |
  Create an instruction file for xUnit usage in this project.
started: "2026-05-18T00:00:00Z"
ended: "2026-05-18T00:00:00Z"
task_durations:
  - task: "xUnit instruction authoring"
    duration: "00:02:00"
total_duration: "00:02:00"
ai_log: "ai-logs/2026/05/18/workspace-core-tech-xunit-20260518/conversation.md"
source: "github-copilot-chat"
---

# xUnit Usage Instructions

- Place all test classes in PostHubAPI.Tests/.
- Use [Fact] for unit tests and [Theory] for parameterized tests.
- Mock dependencies using Moq or similar libraries.
- Follow Arrange-Act-Assert pattern in all tests.
- Name tests as MethodName_StateUnderTest_ExpectedBehavior.
- Run tests in CI and require passing status for merges.
