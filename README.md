## ARCHIVED
Due to SCP:SL removing SCP-330, this plugin is now obsolete and will no longer function. It's been fun to see people using my plugin to disable the infamous pink candy. <3

## SCP-330 Control
Simple SCP:SL Exiled plugin allowing server owners to decide what candies are able to spawn at SCP-330, as well as control over the room itself.

### Configs
| Config Name             | Type   | Default                                                              | Description                                                                                                                                                           |
|-------------------------|--------|----------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| is_enabled              | bool   | true                                                                 | Enables the plugin.                                                                                                                                                   |
| allowed_candies         | List   | RedCandy, YellowCandy, BlueCandy, GreenCandy, PurpleCandy, PinkCandy | Determines what candies can be picked up at SCP-330. Remove candies from this list to prevent them from spawning. Set to empty table `[]` to disable SCP-330 entirely.|
| scp330_lockdown_length  | int    | 0                                                                    | Lock the door to SCP-330 at the start at the round and unlock it after the given amount of seconds. Set to `0` to disable.                                            |
| scp330_lockdown_message | string | SCP-330 is currently under lockdown.                                 | The message to show if a player tries to open the door during the lockdown. Set to `none` to disable.                                                                 |