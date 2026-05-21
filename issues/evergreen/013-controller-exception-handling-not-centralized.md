# Issue: Exception Handling Is Duplicated Across Controllers

## Severity

Medium

## Description

Controllers repeatedly catch domain exceptions and manually map them to HTTP responses.

This duplicates behavior and increases risk of inconsistent error response semantics across endpoints.

## Proposed Updates

1. Introduce centralized exception handling middleware or exception filter.
2. Map known domain exceptions (for example `NotFoundException`) in one place.
3. Remove repetitive controller-level try/catch blocks where global handling applies.
4. Standardize error response structure.

## Verification Steps

1. Trigger known not-found scenarios on post/comment endpoints.
2. Confirm consistent status code and response shape across endpoints.
3. Confirm controllers no longer contain duplicated error mapping boilerplate.
4. Run integration tests for representative error paths.
