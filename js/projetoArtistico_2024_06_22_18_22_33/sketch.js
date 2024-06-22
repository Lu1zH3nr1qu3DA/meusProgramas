  //Isto é um comentário.
function setup() {
  createCanvas(400, 400);
  background(0, 255, 0);
}

function draw() {
  circle(200, 200, 200);
  fill(255, 255, 0);
  stroke(0, 0, 255);
  if (mouseIsPressed) {
    rect(mouseX, mouseY, 100, 200);
  }
}

