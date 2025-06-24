# SCP-1162

This plugin adds SCP-1162 to PT-00 room. I tried to keep it balanced, 
so this won't be a complete replacement of SCP-914.

This plugin is more likely to exchange an item with another within the same category, 
so categories directly influence chances of getting an item.

You always have a 10% chance of getting ammo instead of anything else.

Default config:
```yml
# If the plugin should be enabled
is_enabled: true
# If debug messages should be shown
debug: false
# Hint popup that will be shown to player
hint_on_use: '<color=yellow><i>Вы обменяли предмет в <color=red>SCP-1162</color></color></i>'
# Hint popup when plugin did not accept an item
hint_on_reject: '<color=yellow>Вы ничего не нашли.</color>'
# Items that will be considered common by plugin
common_items:
- Coin
- KeycardJanitor
- Radio
- Lantern
- Medkit
- Painkillers
- Flashlight
- GrenadeFlash
# Items that will be considered uncommon by plugin
uncommon_items:
- KeycardScientist
- KeycardResearchCoordinator
- KeycardZoneManager
- Adrenaline
- ArmorLight
- GunCOM15
- GunCOM18
- SCP207
- SCP1853
- SCP2176
# Items that will be considered good by plugin
good_items:
- KeycardGuard
- SurfaceAccessPass
- KeycardContainmentEngineer
- SCP500
- ArmorCombat
- GunFSP9
- GunCrossvec
- GrenadeHE
# Items that will be considered rare by plugin
rare_items:
- KeycardMTFPrivate
- KeycardMTFOperative
- ArmorHeavy
- GunRevolver
- GunShotgun
- GunCom45
- GunA7
- GunAK
- GunE11SR
- GunSCP127
- AntiSCP207
- SCP1576
- SCP018
# Items that will be considered very rare by plugin
very_rare_items:
- KeycardFacilityManager
- KeycardO5
- KeycardMTFCaptain
- KeycardChaosInsurgency
- ParticleDisruptor
- MicroHID
- Jailbird
- GunFRMG0
- GunLogicer
- SCP268
- SCP1344
```
