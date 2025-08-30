---
name: Refactor Request
about: >
    Commits that restructure or clean up existing code without altering its external behavior.
    Example: Extracting methods for clarity, reorganizing file structure, or improving code readability.
title: '[refactor]:'
labels: ['refactor']
assignees: []
---
## Summary

Refactor the form validation logic to use a schema-based approach instead of manual checks.

## Motivation

Current logic is hard to read and maintain. Moving to `zod` will make it more consistent and testable.

## Tasks

- [ ] Install `zod`
- [ ] Replace manual validation with schema
- [ ] Update error messages
- [ ] Ensure all existing tests pass

## No change in behavior is expected
