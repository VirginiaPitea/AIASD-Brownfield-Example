# Issue: JWT Validation Flags Are Not Explicitly Configured

## Severity

Medium

## Description

JWT bearer validation configuration does not explicitly set some security-critical flags such as `ValidateIssuerSigningKey` and `ValidateLifetime`.

Relying on defaults can lead to security behavior drift during framework or configuration changes.

## Proposed Updates

1. Explicitly set `ValidateIssuerSigningKey = true`.
2. Explicitly set `ValidateLifetime = true`.
3. Set intentional `ClockSkew` value and document rationale.
4. Keep issuer and audience validation explicit and environment-appropriate.

## Verification Steps

1. Confirm explicit token validation flags are present in startup code.
2. Send an expired token and verify unauthorized response.
3. Send token signed with wrong key and verify unauthorized response.
4. Verify valid token still succeeds on protected endpoints.
