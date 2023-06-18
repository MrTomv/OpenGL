#version 330 core

out vec4 FragColor;

//in vec3 TexCoords;
in vec3 Position;
in vec3 Normal;

uniform samplerCube skybox;
uniform vec3 cameraPos;

void main(){
	//reflect
	float ratio = 1.00/1.52;

	vec3 I = normalize(Position - cameraPos);
	//vec3 I = normalize(cameraPos - Position);

	//vec3 R = reflect(I, normalize(Normal));
	vec3 R = refract(I, normalize(Normal), ratio);
	FragColor = vec4(texture(skybox,R).rgb,1.0);
	//FragColor = texture(skybox, TexCoords);
}