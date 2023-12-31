#version 330 core

//layout (points) in;
//layout (line_strip, max_vertices = 2) out;

layout (location = 0) in vec2 aPos;
layout (location = 1) in vec3 aColor;

out VS_OUT{
	vec3 color;
}vs_out;

void main(){
//	gl_Position = vec4(aPos.x, aPos.y, 0.0, 1.0);

//	gl_Position = gl_in[0].gl_Position + vec4(-0.1, 0.0, 0.0, 0.0);
//	EmitVertex();
//	gl_Position = gl_in[0].gl_Position + vec4(0.1, 0.0, 0.0, 0.0);
//	EmitVertex();
//	EndPrimitive();

	gl_Position = vec4(aPos.x, aPos.y, 0.0, 1.0);
	vs_out.color = aColor;


}