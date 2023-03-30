extends Node3D

@export var squares:int
@export var spheres:int

var totalData:Array[String] = []
var frameData:Array[String] = []

var current:int

var square = preload('res://Square.tscn')
var sphere = preload('res://Sphere.tscn')

# Called when the node enters the scene tree for the first time.
func _ready():
	for x in squares:
		var newCube = square.instantiate()
		add_child(newCube)
	for x in spheres:
		var newSphere = sphere.instantiate()
		add_child(newSphere)
# Called every frame. 'delta' is the elapsed time since the previous frame.

func _process(delta):
	if totalData.size() >= 2000:
		save()
		get_tree().quit()
		return
	totalData.append(str(current) + ',' + str(delta) + '\n')
	frameData.append(str(delta) + '\n')
	current += 1

func save():
	var file1 = FileAccess.open("user://total_data.txt", FileAccess.WRITE)
	for x in totalData:
		file1.store_string(x)
	file1 = null
	var file2 = FileAccess.open("user://frame_data.txt", FileAccess.WRITE)
	for x in frameData:
		file2.store_string(x)
	file2 = null
