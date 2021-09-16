import processing.core.PApplet;
import processing.core.PImage;
import java.util.Random;

public class Pong extends PApplet
{
	
    // x position of the ball
    private int ballX;
    // y position of the ball
    private int ballY;
    // Ball speed in the x direction
    private int ballSpeedX;
    // Ball speed in the y direction
    private int ballSpeedY;
    // Width of our window
    final private int width = 640;
    // height of our window
    final private int height = 480;

    //player ones current score
    private int p1Score = 0;
    //player twos current score
    private int p2Score = 0;
    
    //Controls for main menu, game, and game over
    //0 = main menu 1 = game  2 = game over
    private int gameScreen = 0;
    
    //key to change background image
    private String picture = "picture1.png";
    
    //Allows input to screen of users scores
    String p1ScoreConvert;
    String p2ScoreConvert;
    
    
    //High score materials
    private int p1Hits = 0, p2Hits=0;
    
    //stores who won the game
    private String playerWins;

    
    //Initializes Player 1's paddle
    private Paddle p;
    
    //Initialize Player 2's paddle
    private Paddle p2;
    
    public static void main(String[] args) {
        // Set up the processing library
        PApplet.main("Pong");
    }

    public void settings() {
        // Set our window size
        size(width, height);
    }

    public void setup() {
        // Create a random initial position and speed for the ball
        Random r = new Random();
        ballX = r.nextInt(width);
        ballY = r.nextInt(height);
        ballSpeedX = r.nextInt(width / 100) + 1;
        ballSpeedY = r.nextInt(height / 100) + 1;
        
        //create players paddles
        p = new Paddle(25, 100);
        p2 = new Paddle(615, 100);
        
    }

    
    public void draw() {
 
        // Clear the background of the window
        PImage image;
     	size(width, height);
     	image = loadImage(picture);
     	image(image, 0, 0);
     	background(image);
        
     	//changes game state
     	if(gameScreen == 0) {
     		mainMenu();
     	} else if (gameScreen == 1) {
     		gameScreen();
     	} else if (gameScreen == 2) {
     		gameOver();
     	}
     	
     	
    }
    
    //Setup of the main Menu Screen
    public void mainMenu() {

        textSize(100);
    	textAlign(CENTER);
    	text("PONG", 0, height/10, width, height);
    	textSize(20);
    	text("Click Anywhere to Start 2 Player Game", 0, height/3, width, height);
    	textSize(20);
    	text("Press Numbers 1-4 to Change Background Design", 0, height/2, width, height);
    	text("Press Numbers 5-8 to Change Ball and Text Color", 0, 280, width, height);
    	text("First Player to 10 Wins", 0, 320, width, height);
    	text("Press v to Begin Game", 0, 340, width, height);
    	text("Player 1 - W, S Player 2 - Up, Down", 0, 400, width, height);
    	
    	//Change Layout
    	if(keyPressed) {
			if(key == '1') {
				picture = "picture1.png";
			}else if (key == '2') {
				picture = "picture2.jpg";
			}else if(key == '3') {
				picture = "picture3.jpg";
			}else if (key == '4') {
				picture = "picture4.jpg";
			}else if(key =='5') {
				fill(255, 255, 255);
			}
			else if(key == '6') {
		        fill(255, 195, 0);
			}
			else if(key == '7') {
			    fill(255, 0, 0);
			}
			else if (key == '8') {
				fill(255, 102, 255);
			}else if (key == 'v') {
				gameScreen = 1;
			}
			
    	}
    	
    	//Reset scores before playing the games
    	p1Hits = 0;
    	p2Hits = 0;
    }
    
    public void gameOver() {
    	
    	textSize(100);
    	textAlign(CENTER);
    	text("GAME OVER", 0, height/4, width, height);
    	textSize(25);
    	text("Click Anywhere to Return to Main Menu", 0, height-35, width, height);
    	if(playerWins == "Player 1") {
        	text(playerWins + " Wins in " + p1Hits + " Hits!", 0, height/2, width, height);
    	}else if(playerWins == "Player 2") {
        	text(playerWins + " Wins in " + p2Hits + " Hits!", 0, (height/2)+20, width, height);
    	}

    }
    
    //Triggers change between screens
    public void mousePressed() {
    	if(gameScreen == 2) {
    		p1Score = 0;
    		p2Score = 0;
    		gameScreen = 0;
    	}
    }
    
    //Programming for the game
    public void gameScreen() {
    	
    	// Draw the ball
    	ellipse(ballX, ballY, 32, 32);
    	// Move the ball
    	ballX += ballSpeedX;
    	ballY += ballSpeedY;
        	
    	//Change ball direction if off screen
    	if(ballY >= height - 16) {
    		ballSpeedY = -ballSpeedY;;
    	} 
    	else if(ballY <= 16) {
    		ballSpeedY = -ballSpeedY;
    	}
    	//Puts ball back in middle if ball goes off screen on x coordinates
    	else if(ballX >= width) {
    		ballX = width/2;;
    		ballY = height/2;
    		p1Score += 1;
    		Random r = new Random();
    		ballSpeedX = r.nextInt(width / 100) + 1;
    		ballSpeedY = r.nextInt(height / 100) + 1;
    	}
    	else if(ballX <= 0) {
    		ballX = width/2;;
    		ballY = height/2;
    		p2Score += 1;
    		Random r = new Random();
    		ballSpeedX = r.nextInt(width / 100) + 1;
    		ballSpeedY = r.nextInt(height / 100) + 1;
    	}
          
    	//draw the paddles
    	p.draw();
    	p2.draw();
    	//draw text box for score
    	textSize(15);
    	textAlign(LEFT);
    	text("Player One\n Score: "+ Integer.toString(p1Score), 10, 10, 300, 300);
    	text("Player Two\n Score: "+ Integer.toString(p2Score), 540, 10, 500, 500);

    	//calculates for collision based on x coordinates of the ball
    	if(ballX >= 599) {
    		if(ballY >= p2.p_y && ballY <= p2.p_y + 100) {
    			ballSpeedX = -ballSpeedX;
    			ballSpeedX -= 1;
    			p2Hits += 1;
    		}	
    	}
    	else if(ballX <= 41){
    		if(ballY >= p.p_y  && ballY <= p.p_y + 100) {
    			ballSpeedX = -ballSpeedX;
    			ballSpeedX+=1;
    			p1Hits += 1;
    		}
    	}
    
    	//Assigns who won the last game and then changes to game over screen
    	if(p1Score >=10) {
    		playerWins = "Player 1";
    		gameScreen = 2;
    	}else if (p2Score >= 10) {
    		playerWins = "Player 2";
    		gameScreen =2;
    	}
   	}
    
    
   //PADDLE CLASS: Defines object Paddle, gives it position and movements
    class Paddle {
    	int p_height;
    	int p_width;
    	int p_x;
    	int p_y;

    	//Initialize paddle
    	Paddle (){
    		p_height = 100;
    		p_width = 5;
    		p_x = 0;
    		p_y = 0;
    	}
    	
    	Paddle(int x, int y){
    		p_height = 100;
    		p_width = 5;
    		this.p_x = x;
    		this.p_y=y;
    	}
    	
    	//Gives position to paddle
    	public void position(int xPosition, int yPosition) {
    		this.p_x = xPosition;
    		this.p_y = yPosition;
    	}
    	
    	//Returns position
    	int[] getPosition() {
    		
    		int xPosition = this.p_x;
    		int yPosition = this.p_y;
    		int[] pos = {xPosition, yPosition};
    		return pos;
    	}
    	
    	//Draws and moves paddle
    	public void draw() {
    		rect(p_x, p_y, p_width, p_height);
    		
    		//Make p1 go up and down
    		if(keyPressed) {
    			if(key == 'w' || (key == CODED && keyCode == UP)) {
    				if(key == 'w') {
    					p.up();
    				}
    				if(keyCode == UP) {
    					p2.up();
    				}
    			} 
    			else if (key == 's' || (key == CODED && keyCode == DOWN)) {
    				if(key =='s') {
    					p.down();
    				}
    				if(keyCode == DOWN) {
    					p2.down();
    				}
    	    	}	
    		} 
    	}
    	
    	//positively changes y coordinates of the paddle
    	public void up() {
    		if(this.p_y >= 0) {
    			p_y -= 10;
    		}
    	}
    	
    	//negatively changes y coordinates of the paddle
    	public void down() {
    		if((this.p_y + this.p_height) <= height) {
    			p_y += 10;
    		}	
    	}		
    }
}

