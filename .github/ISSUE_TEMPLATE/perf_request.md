---
name: Performance Request
about: Commits are special refactor commits, that improve performance
title: '[perf]:'
labels: 'performance'
assignees: ''
---
## Summary

Use lazy loading and compression for homepage banner images to improve load time.

## Current Behavior

Images are loaded immediately, causing slow initial rendering.

## Improvement Plan

- [ ] Enable lazy loading for non-critical images
- [ ] Compress images using WebP
- [ ] Test loading speed before and after

## Metrics to Watch

- Lighthouse performance score
- Page load time
