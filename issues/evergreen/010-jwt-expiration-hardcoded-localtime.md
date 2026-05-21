# Issue: JWT Expiration Is Hardcoded and Uses Local Time

## Severity

High

## Description

JWT expiration is hardcoded to a fixed duration in service code and uses local time (`DateTime.Now`).

This creates environment drift risk, reduces operational control, and may produce timezone-related token behavior inconsistencies.

## Proposed Updates

1. Move token lifetime to configuration (for example `JWT:AccessTokenMinutes`).
2. Use UTC time (`DateTime.UtcNow`) for token expiration.
3. Validate configured expiration value at startup.
4. Document expected default and override behavior by environment.

## Verification Steps

1. Set token lifetime in configuration.
2. Login and decode token.
3. Confirm `exp` matches configured lifetime from UTC issuance time.
4. Change configured lifetime and verify token expiration changes without code edits.
