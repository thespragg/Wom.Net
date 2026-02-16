# Missing Endpoints

This document tracks the WOM API endpoints that are not yet implemented in Wom.Net.
For full API documentation, see [docs.wiseoldman.net](https://docs.wiseoldman.net/api).

## Groups

The Groups service has entities scaffolded but no service implementation.

| Method | Endpoint | Description |
| ------ | -------- | ----------- |
| GET | `/groups` | Search groups by partial name |
| GET | `/groups/:id` | Get group details |
| POST | `/groups` | Create a new group |
| PUT | `/groups/:id` | Edit a group |
| DELETE | `/groups/:id` | Delete a group |
| POST | `/groups/:id/members` | Add members to a group |
| DELETE | `/groups/:id/members` | Remove members from a group |
| PUT | `/groups/:id/role` | Change a member's role |
| POST | `/groups/:id/update-all` | Update all outdated group members |
| GET | `/groups/:id/competitions` | Get a group's competitions |
| GET | `/groups/:id/gained` | Get top gains for group members |
| GET | `/groups/:id/achievements` | Get recent group member achievements |
| GET | `/groups/:id/records` | Get group member records |
| GET | `/groups/:id/hiscores` | Get group hiscores for a metric |
| GET | `/groups/:id/name-changes` | Get a group's latest name changes |
| GET | `/groups/:id/statistics` | Get group statistics |
| GET | `/groups/:id/activity` | Get recent group activity |
| GET | `/groups/:id/csv` | Export group members as CSV |

## Competitions

The Competitions service has entities scaffolded but no service implementation.

| Method | Endpoint | Description |
| ------ | -------- | ----------- |
| GET | `/competitions` | Search competitions |
| GET | `/competitions/:id` | Get competition details |
| GET | `/competitions/:id/csv` | Export competition as CSV |
| GET | `/competitions/:id/top-history` | Get top 5 participant progress history |
| POST | `/competitions` | Create a competition |
| PUT | `/competitions/:id` | Edit a competition |
| DELETE | `/competitions/:id` | Delete a competition |
| POST | `/competitions/:id/participants` | Add participants |
| DELETE | `/competitions/:id/participants` | Remove participants |
| POST | `/competitions/:id/teams` | Add teams |
| DELETE | `/competitions/:id/teams` | Remove teams |
| POST | `/competitions/:id/update-all` | Update all outdated participants |

## Deltas

The Deltas service has entities scaffolded but no service implementation.

| Method | Endpoint | Description |
| ------ | -------- | ----------- |
| GET | `/deltas/leaderboard` | Get the top deltas leaderboard for a metric and period |

## Efficiency

The Efficiency service has entities scaffolded but no service implementation.

| Method | Endpoint | Description |
| ------ | -------- | ----------- |
| GET | `/efficiency/leaderboard` | Get the efficiency leaderboard for a metric |
| GET | `/efficiency/rates` | Get efficiency rates for skills and bosses |
