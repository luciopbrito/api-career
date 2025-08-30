---
name: Feature Request
about: >
    Commits that introduce a new feature or significant functionality to the codebase.
    Example: Adding a user profile page, implementing dark mode, or integrating a new API.
title: '[feat]:'
labels: ['feature']
assignees: []

---

## Summary

Add a dark mode toggle in the settings menu to allow users to switch between light and dark themes.

## Motivation

Requested by users for better accessibility and eye comfort in low-light environments.

## Tasks

- [ ] Create toggle component
- [ ] Update theme context/state
- [ ] Store preference in localStorage
- [ ] Add styles for dark theme
- [ ] Test theme switching logic

## Definition of Done

Dark mode toggle is visible in settings and persists user preference across sessions.
