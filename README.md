## SCP-330 Control
Simple SCP:SL Exiled plugin allowing server owners to decide what candies are able to spawn at SCP-330.

### Configs
| Config Name             | Type   | Default                                                              | Description                                                                                                              |
|-------------------------|--------|----------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| is_enabled              | bool   | true                                                                 | Enables the plugin.                                                                                                      |
| allowed_candies         | List   | RedCandy, YellowCandy, BlueCandy, GreenCandy, PurpleCandy, PinkCandy | Determines what candies can be picked up at SCP-330. Remove candies from this list to prevent them from spawning.        |
| scp330_lockdown_length  | int    | 0                                                                    | Lock the door to SCP-330 at the start at the round and unlock it after the given amount of seconds. Set to 0 to disable. |
| scp330_lockdown_message | string | SCP-330 is currently under lockdown.                                 | The message to show if a player tries to open the door during the lockdown. Set to none to disable.                      |