---
name: Fix Request
about: >
    Commits that resolve a bug, error, or unintended behavior in the application.
    Example: Fixing a crash on form submission or correcting an off-by-one error in pagination.
title: '[fix]:'
labels: ['fix']
assignees: []
---
## Bug Description

Uploading images larger than 5MB causes the app to crash due to memory overflow.

## Steps to Reproduce

1. Go to "Upload Image"
2. Select an image >5MB
3. Click Upload

## Expected Behavior

Image should upload successfully or show an error if size limit exceeded.

## Actual Behavior

App freezes and crashes after uploading large files.

## Fix Plan

- [ ] Add file size validation on client side
- [ ] Limit upload buffer size on backend

## Environment

- OS: Windows 11
- Browser: Chrome v114
