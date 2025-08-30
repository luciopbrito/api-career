---
name: Operational Request
about: >
    Commits relate to infra deploy pipelines, monitoring, backups, or operational tasks. Example: Setting up server provisioning scripts, adding database backups, or updating deployment environments.
title: '[ops]:'
labels: ['operational']
assignees: []
---
## Summary

Automate database backups to S3 every night at midnight.

## Tasks

- [ ] Create backup script
- [ ] Schedule cron job
- [ ] Configure AWS credentials in CI/CD
- [ ] Test restoration from backup

## Motivation

Improve disaster recovery preparedness.
