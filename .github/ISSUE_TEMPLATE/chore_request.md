---
name: Chore Request
about: >
    Miscellaneous commits that don’t affect source code or runtime behavior directly, often related to project maintenance. Example: .gitignore, renaming a config file, or cleaning up temporary assets.
title: '[chore]:'
labels: ['chore']
assignees: []
---
## Summary

Update `.gitignore` to prevent macOS system files from being committed.

## Motivation

Clean up the repo and prevent unnecessary files from cluttering diffs.

## Tasks

- [ ] Add `.DS_Store` to `.gitignore`
- [ ] Remove existing tracked .DS_Store files
