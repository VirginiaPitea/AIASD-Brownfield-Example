---
ai_generated: true
model: "openai/gpt-5.3-codex@unknown"
operator: "GitHub Copilot"
chat_id: "create-auth-jwt-instructions-20260521"
prompt: |
  create auth JWT instructions
started: "2026-05-21T00:20:00Z"
ended: "2026-05-21T00:28:00Z"
task_durations:
  - task: "requirements alignment"
    duration: "00:03:00"
  - task: "instruction authoring"
    duration: "00:04:00"
  - task: "traceability updates"
    duration: "00:01:00"
total_duration: "00:08:00"
ai_log: "ai-logs/2026/05/21/create-auth-jwt-instructions-20260521/conversation.md"
source: "github-copilot-chat"
name: auth-jwt
description: Guidance for JWT authentication and authorization setup in this repository
applyTo: "**/*"
version: "1.0.0"
author: "GitHub Copilot"
tags: ["jwt", "authentication", "authorization", "aspnetcore", "security"]
owner: "Development Team"
reviewedDate: "2026-05-21"
nextReview: "2026-08-21"
---

# JWT Authentication and Authorization Instructions

## Overview

Use these instructions for JWT token issuance, validation, and authorization behavior across the API. Apply these rules when updating auth configuration, token generation, protected endpoints, and auth-related tests.

## Configuration Rules

- Keep signing secrets out of source control.
- Resolve JWT settings from configuration providers in this order: environment variables, user secrets, appsettings.
- Require a non-empty signing secret at startup and fail fast if missing.
- Use `JWT:Secret` (or `JWT__Secret`) as the canonical secret key name.
- Use explicit values for issuer, audience, and expiration settings; avoid hidden defaults in production.

## Token Validation Rules

- Enable `ValidateIssuerSigningKey` and use a symmetric key derived from the configured secret.
- Enable `ValidateLifetime` to reject expired tokens.
- Enable `ValidateIssuer` and `ValidateAudience` in production.
- Keep clock skew minimal and intentional.
- Keep `RequireHttpsMetadata` enabled outside development.

## Token Issuance Rules

- Issue tokens only after successful credential validation.
- Include stable subject and identifier claims (`sub`, `nameid`, and role claims as needed).
- Use short-lived access tokens; do not create long-lived bearer tokens by default.
- Never include sensitive secrets in token claims.

## Endpoint Authorization Rules

- Protect write operations and private resources with `[Authorize]`.
- Use `[AllowAnonymous]` only on endpoints explicitly intended to be public (for example, login and registration).
- Use role or policy-based authorization for admin or privileged operations.
- Keep authorization checks in service/business layer for complex rules, not only at the controller attribute level.

## Error Handling and Response Behavior

- Return `401 Unauthorized` for missing or invalid tokens.
- Return `403 Forbidden` for authenticated users lacking required permission.
- Do not leak token validation internals in API responses.
- Log auth failures with enough context for diagnostics but without writing secrets or full tokens.

## Security and Operations

- Rotate JWT signing secrets regularly.
- Invalidate old tokens as part of secret rotation strategy.
- Require HTTPS in non-development environments.
- Audit auth configuration changes during review and release.

## Testing Requirements

- Add unit tests for token creation behavior and claim composition.
- Add integration tests covering success and failure paths for protected endpoints.
- Verify `401` for anonymous access and `403` for insufficient privileges.
- Include tests for invalid, expired, and malformed tokens.

## References

- [ASP.NET Core authentication and authorization](https://learn.microsoft.com/aspnet/core/security/authentication/)
- [JWT bearer authentication in ASP.NET Core](https://learn.microsoft.com/aspnet/core/security/authentication/configure-jwt-bearer-authentication)

---

**Document Version**: 1.0.0
**Last Updated**: 2026-05-21
**Maintainer**: Development Team
**Related Instructions**: [.github/instructions/aspnetcore.instructions.md](.github/instructions/aspnetcore.instructions.md), [.github/instructions/evergreen-software-development.instructions.md](.github/instructions/evergreen-software-development.instructions.md), [.github/instructions/ai-assisted-output.instructions.md](.github/instructions/ai-assisted-output.instructions.md)
