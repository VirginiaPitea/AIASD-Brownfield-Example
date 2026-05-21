# Issue: Legacy BCrypt Package Still Referenced

## Severity

High

## Description

The project file still references legacy `BCrypt.Net` version `0.1.0`, despite no active usage in the current codebase.

Unused legacy dependencies increase maintenance and security risk.

## Proposed Updates

1. Remove `BCrypt.Net` package reference from project file.
2. Restore and rebuild solution.
3. If password hashing customization is needed later, use ASP.NET Identity hashing or a maintained package compatible with .NET 8.

## Verification Steps

1. Remove dependency reference.
2. Run `dotnet restore`.
3. Run `dotnet build`.
4. Smoke test registration/login endpoints.
5. Confirm no dependency compatibility warning remains.
