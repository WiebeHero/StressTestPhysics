extends Node3D

@onready var spawner = $Spawner
@onready var animator = $Walls/AnimationPlayer

# Called when the node enters the scene tree for the first time.
func _ready():
	animator.play("Move")


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass

func _notification(what):
	if what == NOTIFICATION_WM_CLOSE_REQUEST:
		spawner.save()

func _on_animation_player_animation_finished(anim_name):
	animator.play(anim_name)
