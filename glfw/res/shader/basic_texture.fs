#version 330 core
out vec4 FragColor;

in vec3 ourColor;   //颜色着色器
in vec2 TexCoord;	//纹理着色器

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;


void main()
{
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
}