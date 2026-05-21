# Issue: Authorization Tests Missing JWT Failure Scenarios

## Severity

Medium

## Description

Current authorization tests cover anonymous unauthorized access and valid token success, but do not cover key negative token scenarios.

Missing scenarios include invalid signature, malformed token, and expired token handling.

## Proposed Updates

1. Add integration tests for:
   - expired JWT
   - malformed JWT
   - wrong-signature JWT
2. Add tests for forbidden authorization behavior (`403`) when policy/role checks exist.
3. Keep existing anonymous `401` tests.

## Verification Steps

1. Run test suite after adding negative auth scenarios.
2. Confirm invalid/expired/malformed tokens return `401`.
3. Confirm insufficient permission path returns `403` when applicable.
4. Confirm valid token path remains green.
