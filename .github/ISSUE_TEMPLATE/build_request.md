---
name: Build Request
about: >
    Commits that modify the build system, package manager settings, project versioning, or CI/CD configs. Example: Upgrading dependencies, configuring Webpack, or adjusting GitHub Actions workflows
title: '[build]:'
labels: ['build']
assignees: []
---
## Summary

Update Node version to 20.0 and upgrade all outdated dependencies to maintain security and compatibility.

## Tasks

- [ ] Update `.nvmrc`
- [ ] Bump major dependencies (e.g., React, Express)
- [ ] Fix breaking changes
- [ ] Update CI pipeline config

## Testing

Ensure build passes locally and on CI.
