# Issue: JWT Tokens Missing Stable Subject Identifier Claims

## Severity

High

## Description

JWT token issuance includes name and email claims but does not include stable identifier claims such as `sub` and `nameid`.

Missing stable identity claims can break downstream authorization assumptions and make audit correlation harder.

## Proposed Updates

1. Add stable identity claims when generating JWT tokens:
   - `sub`
   - `nameid`
2. Keep name and email claims as supplemental claims.
3. Document required claim set for all issued access tokens.

## Verification Steps

1. Generate a JWT via login.
2. Decode token payload.
3. Confirm `sub` and `nameid` are present and populated with stable user identity.
4. Confirm existing protected endpoints still authorize successfully.
