# Issue: Edit Post Validation Is Inconsistent with Create Post Validation

## Severity

Medium

## Description

`CreatePostDto` enforces required and length constraints while `EditPostDto` has no validation annotations.

This inconsistency allows edit requests to bypass input quality controls applied at create time.

## Proposed Updates

1. Align `EditPostDto` validation with `CreatePostDto` when full replacement semantics are intended.
2. If partial updates are intended, switch to PATCH and define nullable validation rules explicitly.
3. Add tests for invalid edit payloads.

## Verification Steps

1. Apply chosen validation strategy to edit DTO.
2. Send invalid edit payloads and verify `400 Bad Request`.
3. Send valid edit payload and verify success.
4. Confirm create/edit behavior is consistent with intended API semantics.
