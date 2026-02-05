output "server_ip" {
  description = "The ip address the server is reachable on"
  value       = hcloud_server.server.ipv4_address
}
