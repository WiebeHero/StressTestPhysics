extends Node3D

@export var squares:int

@export var sampleSize:int

var totalData:Array[String] = []
var frameData:Array[String] = []

var allSquares:Array[RigidBody3D] = []

var current:int

var square = preload('res://Square.tscn')
var sphere = preload('res://Sphere.tscn')

# Called when the node enters the scene tree for the first time.
func _ready():
	for x in squares:
		var newCube = square.instantiate()
		add_child(newCube)
		allSquares.append(newCube.get_child(0));
# Called every frame. 'delta' is the elapsed time since the previous frame.

func _process(delta):
	##var squareCount:int = 0;
	##var sphereCount:int = 0;
	##for x in allSquares:
	##	if position.distance_to(x.position) > 40.0:
	##		squareCount += 1;
	##for x in allSpheres:
	##	if position.distance_to(x.position) > 40.0:
	##		sphereCount += 1;
	##print("Missing squares: " + str(squareCount));
	##print("Missing spheres: " + str(sphereCount));
	if totalData.size() >= sampleSize:
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
